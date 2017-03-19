using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MECS.Core.Contracts;
using MECS.Core.Engraving;
using Microsoft.Practices.Unity;

namespace MECS.UI.App
{
    public partial class FrmMain : Form
    {
        private readonly IUnityContainer _unityContainer;
        private IEngraver _engraver;

        public FrmMain()
        {
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

        private void EraseMachineMemory(object sender, EventArgs e)
        {
            _engraver?.EraseImage();
        }

        private void EngravePicture(object sender, EventArgs e)
        {
            if (PictureBox.Image == null || 
                _engraver == null)
            {
                return;
            }

            using (var memorystream = new MemoryStream())
            {
                PictureBox.Image.Save(memorystream, ImageFormat.Bmp);

                _engraver?.SendImage(memorystream);
            }
        }

        private void LoadPicture(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Image imageToLoad = new Bitmap(openFileDialog1.FileName);

            Bitmap workingBitmap = new Bitmap(512, 512);

            using (Graphics graphics = Graphics.FromImage((Image)workingBitmap))
            {
                graphics.FillRegion(new SolidBrush(Color.White), new Region(new Rectangle(0, 0, 512, 512)));

                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                
                graphics.DrawImage(imageToLoad, 0, 0);
            }

            PictureBox.Image = workingBitmap.Clone(
                new Rectangle(0, 0, workingBitmap.Width, workingBitmap.Height),
                PixelFormat.Format1bppIndexed);

            BtnEngrave.Enabled = true;
        }
    }
}
