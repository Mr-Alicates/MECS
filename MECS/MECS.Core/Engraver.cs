using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MECS.Core.Contracts;
using MECS.Core.Model;

namespace MECS.Core
{
    public class Engraver : IEngraver
    {
        private SerialPort _port;
        private bool _connected = false;

        public bool Connect()
        {
            var port = SerialPort.GetPortNames().FirstOrDefault();

            if (port == null)
            {
                throw new ArgumentException("No port available");
            }

            //Settings
            _port = new SerialPort(port, 57600, Parity.None, 8, StopBits.One);

            _port.Open();

            _port.Write(new byte[] {0xF6}, 0, 1);

            byte[] response = new byte[1];

            var responseBytes = _port.Read(response, 0, 1);

            if (responseBytes != 1)
            {
                return false;
            }

            _connected = response[0] == 0x65;

            return _connected;
        }

        public void Move(MovementType movementType)
        {
            byte[] operation = new byte[0];

            if (movementType == MovementType.Up)
            {
                operation = new byte[] { 0xF5, 0x01 };
            }

            if (movementType == MovementType.Down)
            {
                operation = new byte[] { 0xF5, 0x02 };
            }

            if (movementType == MovementType.Left)
            {
                operation = new byte[] { 0xF5, 0x03 };
            }

            if (movementType == MovementType.Right)
            {
                operation = new byte[] { 0xF5, 0x04 };
            }


            _port.Write(operation, 0, operation.Length);
        }
    }
}
