using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
