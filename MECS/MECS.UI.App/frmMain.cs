using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using MECS.Core.Engraving;

namespace MECS.UI.App
{
    public partial class FrmMain : Form
    {
        private EngravingService _engravingService = new EngravingService();

        public FrmMain()
        {
            //I need this to be able to modify controls from other thread
            CheckForIllegalCrossThreadCalls = false;

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
                NumBurningTime.Minimum = _engravingService.GetMinimumBurningTime();
                NumBurningTime.Maximum = _engravingService.GetMaximumBurningTime();
                NumBurningTime.Value = NumBurningTime.Minimum;
            }
        }

        private void FormLoad(object sender, EventArgs e)
        {
            //Fill connection combos
            CmbAvailableDrivers.Items.Clear();
            CmbAvailablePorts.Items.Clear();

            CmbAvailableDrivers.Items.AddRange(_engravingService.GetAvaliableDrivers());
            CmbAvailablePorts.Items.AddRange(_engravingService.GetAvailablePorts());
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

            _engravingService.ConnectToEngraver(driverType, comPort);

            SetConnnectionStatus(true);
        }

        private void DisconnectEngraver(object sender, EventArgs e)
        {
            _engravingService.DisconnectFromEngraver();

            SetConnnectionStatus(false);
        }

        #region Engraver movement

        private void MoveToOrigin(object sender, EventArgs e)
        {
            _engravingService?.MoveToOrigin();
        }

        private void MoveToCenter(object sender, EventArgs e)
        {
            _engravingService?.MoveToCenter();
        }

        private void Preview(object sender, EventArgs e)
        {
            _engravingService?.Preview();
        }

        private void MoveUp(object sender, EventArgs e)
        {
            _engravingService?.MoveUp();
        }

        private void MoveLeft(object sender, EventArgs e)
        {
            _engravingService?.MoveLeft();
        }

        private void MoveDown(object sender, EventArgs e)
        {
            _engravingService?.MoveDown();
        }

        private void MoveRight(object sender, EventArgs e)
        {
            _engravingService?.MoveRight();
        }

        #endregion

        private void SetBurningTime(object sender, EventArgs e)
        {
            _engravingService.SetBurningTime(NumBurningTime.Value);
        }

        private void PauseEngraving(object sender, EventArgs e)
        {
            _engravingService?.PauseEngraving();
        }

        private void SendImageToMachine(object sender, EventArgs e)
        {
            if (PbxToEngrave.Image == null)
            {
                return;
            }

            Task.Run(() =>
            {
                txtMachineStatus.Text = "Sending";

                _engravingService.SendImageToMachine();

                txtMachineStatus.Text = "Sent";
            });
        }

        private void EngravePicture(object sender, EventArgs e)
        {
            SetBurningTime(sender, e);

            Task.Run(() =>
            {
                txtMachineStatus.Text = "Engraving";

                IEnumerable<EngraverPosition> positions = _engravingService.EngravePicture();

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

            _engravingService.LoadOriginalPicture(openFileDialog1.FileName);

            RecalulatePictureBoxes(this, null);
        }


        private void RecalulatePictureBoxes(object sender, EventArgs e)
        {
            bool stretchPicture = ChkStretchToSize.Checked;
            bool keepAspectRatio = ChkKeepAspectRatio.Checked;

            _engravingService.CalculatePictureToBeProcessed(stretchPicture, keepAspectRatio);

            PbxOriginal.Image = _engravingService.GetOriginalImage();
            PbxToEngrave.Image = _engravingService.GetWorkingImage();
        }

        private void Stop(object sender, EventArgs e)
        {
            txtXPosition.Text = "";
            txtYPosition.Text = "";
            txtMachineStatus.Text = "";
            prgEngravingProgress.Value = 0;

            Task.Run(() =>
            {
                _engravingService.RestartMachine();
            });
        }
    }
}
