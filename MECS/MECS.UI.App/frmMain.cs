using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MECS.Core.Contracts;
using MECS.Core.Engraving;
using MECS.Core.Images;
using Microsoft.Practices.Unity;

namespace MECS.UI.App
{
    public partial class FrmMain : Form
    {
        private readonly IUnityContainer _unityContainer;
        private IEngraver _engraver;
        private Image _pictureBeingProcessed;
        private Image _pictureToMachine;

        public FrmMain()
        {
            //I need this to be able to modify controls from other thread
            CheckForIllegalCrossThreadCalls = false;

            _unityContainer = ContainerBuilder.BuildContainer();
            InitializeComponent();
        }

        private void SetConnnectionStatus(bool connected)
        {
            BtnConnect.Enabled = !connected;
            BtnDisconnect.Enabled = connected;
            GrpMovement.Enabled = connected;
            GrpBurningTime.Enabled = connected;
            GrpEngravingControls.Enabled = connected;
            GrpPicture.Enabled = connected;

            if (connected)
            {
                NumBurningTime.Minimum = _engraver.GetMinimumBurningTime();
                NumBurningTime.Maximum = _engraver.GetMaximumBurningTime();
                NumBurningTime.Value = NumBurningTime.Minimum;
            }
        }

        private void FormLoad(object sender, EventArgs e)
        {
            //Fill connection combos
            CmbAvailableDrivers.Items.Add(typeof(NejeDk8KzEngraver));
            CmbAvailableDrivers.Items.Add(typeof(MockEngraver));

            foreach (var port in SerialPort.GetPortNames())
            {
                CmbAvailablePorts.Items.Add(port);
            }
        }

        private void ConnectToEngraver(object sender, EventArgs e)
        {
            Type driverType = CmbAvailableDrivers.SelectedItem as Type;

            if (driverType == null)
            {
                //TODO message 
                return;
            }

            string comPort = CmbAvailablePorts.SelectedItem as string;

            IEngraverFactory engraverFactory = _unityContainer.Resolve<IEngraverFactory>();

            _engraver = engraverFactory.Build(driverType, comPort);

            SetConnnectionStatus(true);
        }

        private void DisconnectEngraver(object sender, EventArgs e)
        {
            _engraver.Dispose();

            SetConnnectionStatus(false);
        }

        #region Engraver movement

        private void MoveToOrigin(object sender, EventArgs e)
        {
            _engraver?.MoveToOrigin();
        }

        private void MoveToCenter(object sender, EventArgs e)
        {
            _engraver?.MoveToCenter();
        }

        private void Preview(object sender, EventArgs e)
        {
            _engraver?.Preview();
        }

        private void MoveUp(object sender, EventArgs e)
        {
            _engraver?.MoveUp();
        }

        private void MoveLeft(object sender, EventArgs e)
        {
            _engraver?.MoveLeft();
        }

        private void MoveDown(object sender, EventArgs e)
        {
            _engraver?.MoveDown();
        }

        private void MoveRight(object sender, EventArgs e)
        {
            _engraver?.MoveRight();
        }

        #endregion

        private void SetBurningTime(object sender, EventArgs e)
        {
            _engraver.SetBurningTime(NumBurningTime.Value);
        }

        private void PauseEngraving(object sender, EventArgs e)
        {
            _engraver?.PauseEngraving();
        }

        private void SendImageToMachine(object sender, EventArgs e)
        {
            if (PbxToEngrave.Image == null ||
                    _engraver == null)
            {
                return;
            }

            Task.Run(() =>
            {
                txtMachineStatus.Text = "Sending";

                byte[] image = new byte[32830];

                using (var memorystream = new MemoryStream(image))
                {
                    _pictureToMachine.Save(memorystream, ImageFormat.Bmp);
                }

                _engraver?.SendImage(image);

                txtMachineStatus.Text = "Sent";
            });
        }

        private void EngravePicture(object sender, EventArgs e)
        {
            SetBurningTime(sender, e);

            Task.Run(() =>
            {
                txtMachineStatus.Text = "Engraving";

                IEnumerable<EngraverPosition> positions = _engraver.StartEngraving();

                foreach (var position in positions)
                {
                    txtXPosition.Text = position.X.ToString();
                    txtYPosition.Text = position.Y.ToString();

                    prgEngravingProgress.Value = position.Y;
                }

                prgEngravingProgress.Value = prgEngravingProgress.Maximum;
                txtMachineStatus.Text = "Engraved";
            });
        }

        private void LoadPicture(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            _pictureBeingProcessed = new Bitmap(openFileDialog1.FileName);

            RecalulatePictureBoxes(this, null);
        }

        private void RecalulatePictureBoxes(object sender, EventArgs e)
        {
            bool stretchPicture = ChkStretchToSize.Checked;
            bool keepAspectRatio = ChkKeepAspectRatio.Checked;

            if (stretchPicture)
            {
                PbxOriginal.Image = ImageHelper.EscaleImage(
                    _pictureBeingProcessed, 
                    PbxOriginal.Size.Width,
                    PbxOriginal.Size.Height, 
                    keepAspectRatio);
            }
            else
            {
                PbxOriginal.Image = _pictureBeingProcessed;
            }

            Bitmap workingBitmap = new Bitmap(512, 512);

            using (Graphics graphics = Graphics.FromImage((Image)workingBitmap))
            {
                graphics.FillRegion(new SolidBrush(Color.White), new Region(new Rectangle(0, 0, 512, 512)));

                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                Image img = (Image)PbxOriginal.Image.Clone();

                img.RotateFlip(RotateFlipType.Rotate180FlipX);

                graphics.DrawImage(img, 0, 0);
            }

            _pictureToMachine = workingBitmap.Clone(
                new Rectangle(0, 0, workingBitmap.Width, workingBitmap.Height),
                PixelFormat.Format1bppIndexed);

            PbxToEngrave.Image = (Image)_pictureToMachine.Clone();
            PbxToEngrave.Image.RotateFlip(RotateFlipType.Rotate180FlipX);


            BtnEngrave.Enabled = true;
        }

        private void Stop(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                _engraver.RestartMachine();
                txtXPosition.Text = "";
                txtYPosition.Text = "";
                txtMachineStatus.Text = "";
                prgEngravingProgress.Value = 0;
            });
        }
    }
}
