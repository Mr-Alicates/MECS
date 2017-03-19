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
        private readonly IUnityContainer UnityContainer;
        private IEngraver Engraver;

        public FrmMain()
        {
            UnityContainer = ContainerBuilder.BuildContainer();
            InitializeComponent();
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

            IEngraverFactory engraverFactory = UnityContainer.Resolve<IEngraverFactory>();

            Engraver = engraverFactory.Build(driverType, comPort);

            BtnConnect.Enabled = false;
            BtnDisconnect.Enabled = true;
        }

        private void DisconnectEngraver(object sender, EventArgs e)
        {
            Engraver.Dispose();

            BtnConnect.Enabled = true;
            BtnDisconnect.Enabled = false;
        }
    }
}
