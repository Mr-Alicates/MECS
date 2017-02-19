using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MECS.Core.Contracts;
using MECS.Core.Model;

namespace MECS.Core
{
    public class Engraver : IEngraver
    {
        private readonly Dictionary<string, byte[]> _commands = new Dictionary<string, byte[]>()
        {
            {"Connect", new byte[] { 0xF6 } },
            {"ConnectResponse", new byte[] { 0x65 } },

            {MovementType.Up.ToString(), new byte[] { 0xF5, 0x01 } },
            {MovementType.Down.ToString(), new byte[] { 0xF5, 0x02 } },
            {MovementType.Left.ToString(), new byte[] { 0xF5, 0x03 } },
            {MovementType.Right.ToString(), new byte[] { 0xF5, 0x04 } },

            {MovementType.Origin.ToString(), new byte[] { 0xF3 } },
            {MovementType.Center.ToString(), new byte[] { 0xFB } },
            {MovementType.Preview.ToString(), new byte[] { 0xF4 } },

            {"Pause", new byte[] { 0xF2 } },
            {"Start", new byte[] { 0xF1 } },
            {"Restart", new byte[] { 0xF9 } },

            { "EraseImage", new byte[] {0xFE, 0xFE, 0xFE, 0xFE, 0xFE, 0xFE, 0xFE, 0xFE} },

            { "Close", new byte[] {} },
        }; 

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

            ExecuteCommand("Connect");

            byte[] response = new byte[1];

            var responseBytes = _port.Read(response, 0, 1);

            if (responseBytes != 1)
            {
                return false;
            }

            _connected = response[0] == _commands["ConnectResponse"][0];

            return _connected;
        }

        public void Move(MovementType movementType)
        {
            ExecuteCommand(movementType.ToString());
        }

        public void Restart()
        {
            ExecuteCommand("Restart");
        }

        public void Pause()
        {
            ExecuteCommand("Pause");
        }

        public void Start()
        {
            ExecuteCommand("Start");

            _port.ReadTimeout = 5000;
            
            try
            {
                while (true)
                {
                    byte[] response = new byte[1];

                    _port.Read(response, 0, response.Length);

                    if (response[0] == 0x66)
                    {
                        break;
                    }

                    byte[] bytes = new byte[4];

                    _port.Read(bytes, 0, bytes.Length);

                    var x = bytes[0]*100 + bytes[1];
                    var y = bytes[2]*100 + bytes[3];
                    
                    Console.WriteLine($"X:{x} Y:{y}");
                }
            }
            catch (Exception ex)
            {
                
            }

        }

        public void SendImage(string pathToImage)
        {
            ExecuteCommand("EraseImage");
            Thread.Sleep(10000);

            var image = new Bitmap(pathToImage);
            image.RotateFlip(RotateFlipType.RotateNoneFlipY);

            Bitmap b = new Bitmap(512, 512);
          
            using (Graphics g = Graphics.FromImage((Image)b))
            {
                g.FillRegion(new SolidBrush(Color.White), new Region(new Rectangle(0,0, 512, 512)) );

                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 22, 490, 490);
            }

            var rectangle = new Rectangle(0, 0, b.Width, b.Height);
            
            var bmp1bpp = b.Clone(rectangle, PixelFormat.Format1bppIndexed);

            byte[] byteArray = new byte[32830];

            MemoryStream memoryStream = new MemoryStream(byteArray);
            
            bmp1bpp.Save(memoryStream, ImageFormat.Bmp);
            
            _port.Write(byteArray, 0, byteArray.Length);
            Thread.Sleep(2000);
        }

        public void SetBurningTime(byte intensity)
        {
            const byte minimum = 1;

            const byte maximum = 120;

            intensity = Math.Max(minimum, Math.Min(intensity, maximum));
            
            _port.Write(new byte[] { intensity }, 0, 1);
        }

        private void ExecuteCommand(string command)
        {
            if (!_commands.ContainsKey(command))
            {
                return;
            }

            byte[] operation = _commands[command];

            _port.Write(operation, 0, operation.Length);
            Thread.Sleep(5000);
        }

        public void Dispose()
        {
            if (_port.BytesToRead > 0)
            {
                var bytes = new byte[_port.BytesToRead];

                _port.Read(bytes, 0, bytes.Length);
            }
            ExecuteCommand("Close");
            _port.DiscardInBuffer();
            _port.DiscardOutBuffer();
            _port.Close();
            _port.Dispose();
            //This sleep seems necessary so the serial port is properly closed. 
            //If not, the engraver will need to be unplugged and plugged again to be responsive
            Thread.Sleep(1000);
            _port = null;
        }
    }
}
