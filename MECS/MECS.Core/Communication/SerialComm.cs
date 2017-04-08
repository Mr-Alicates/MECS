using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MECS.Core.Contracts;

namespace MECS.Core.Communication
{
    /// <summary>
    /// This class wrapps the SerialPort system class. 
    /// The idea is to make unit testing easier since SerialPort cannot be mocked.
    /// </summary>
    public class SerialComm : ISerialComm
    {
        private const int SleepTimeAfterCommands = 3000;
        private const int ReadTimeout = 30000;
        
        private SerialPort _port;

        private void CheckPort()
        {
            if (_port == null)
            {
                throw new InvalidOperationException("SerialComm is not open");
            }
            if (!IsOpen)
            {
                throw new InvalidOperationException("Cannot perform operation. Machine is not connected");
            }
        }

        public bool IsOpen => _port.IsOpen;

        public void Open(string port, int baudRate, Parity parity, int dataBits, StopBits stopBits)
        {
            _port = new SerialPort(port, baudRate, parity, dataBits, stopBits);
            _port.Open();
            _port.ReadTimeout = ReadTimeout;
        }
        
        public void Write(params byte[] data)
        {
            CheckPort();

            _port.Write(data, 0, data.Length);
            Thread.Sleep(SleepTimeAfterCommands);
        }

        public byte ReadOne()
        {
            return ReadMany(1)[0];
        }

        public byte[] ReadMany(int bytesToRead)
        {
            CheckPort();

            var response = new byte[bytesToRead];

            _port.Read(response, 0, response.Length);

            return response;
        }

        public void Dispose()
        {
            CheckPort();

            _port.Close();
            _port.Dispose();
            //This sleep seems necessary so the serial port is properly closed. 
            //If not, the engraver will need to be unplugged and plugged again to be responsive
            Thread.Sleep(SleepTimeAfterCommands);
        }
    }
}
