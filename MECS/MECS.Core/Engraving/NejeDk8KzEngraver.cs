using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Ports;
using System.Threading;
using MECS.Core.Contracts;

namespace MECS.Core.Engraving
{
    /// <summary>
    /// This class provides the control logic for the Neje DK-8-KZ laser engraver
    /// </summary>
    public class NejeDk8KzEngraver : IEngraver
    {
        private readonly ISerialComm _serialComm;
        
        public NejeDk8KzEngraver(ISerialComm serialComm)
        {
            if (serialComm == null)
            {
                throw new ArgumentNullException(nameof(serialComm));
            }

            _serialComm = serialComm;
        }

        public bool IsOpen => _serialComm.IsOpen;

        public bool Connect(string port)
        {
            _serialComm.Open(
                port, 
                NejeDk8KzConstants.BaudRate, 
                NejeDk8KzConstants.Parity, 
                NejeDk8KzConstants.DataBits, 
                NejeDk8KzConstants.StopBits);

            _serialComm.Write(NejeDk8KzConstants.ConnectCommand);

            byte result = _serialComm.ReadOne();

            return result == NejeDk8KzConstants.ConnectResponse;
        }

        public void MoveUp()
        {
            _serialComm.Write(NejeDk8KzConstants.MoveCommand, NejeDk8KzConstants.MoveUpCommand);
        }

        public void MoveDown()
        {
            _serialComm.Write(NejeDk8KzConstants.MoveCommand, NejeDk8KzConstants.MoveDownCommand);
        }

        public void MoveLeft()
        {
            _serialComm.Write(NejeDk8KzConstants.MoveCommand, NejeDk8KzConstants.MoveLeftCommand);
        }

        public void MoveRight()
        {
            _serialComm.Write(NejeDk8KzConstants.MoveCommand, NejeDk8KzConstants.MoveRightCommand);
        }

        public void MoveToCenter()
        {
            _serialComm.Write(NejeDk8KzConstants.CenterCommand);
        }

        public void MoveToOrigin()
        {
            _serialComm.Write(NejeDk8KzConstants.OriginCommand);
        }

        public void Preview()
        {
            _serialComm.Write(NejeDk8KzConstants.PreviewCommand);
        }
        
        public void Restart()
        {
            _serialComm.Write(NejeDk8KzConstants.RestartCommand);
        }

        public void Pause()
        {
            _serialComm.Write(NejeDk8KzConstants.PauseCommand);
        }

        public void Start()
        {
            _serialComm.Write(NejeDk8KzConstants.StartCommand);

            while (true)
            {
                var response = _serialComm.ReadOne();

                if (response == NejeDk8KzConstants.EngravingFinishedResponse)
                {
                    break;
                }

                if (response != NejeDk8KzConstants.PositionUpdatedResponse)
                {
                    //Unexpected response, abort!
                    Restart();
                    throw new InvalidOperationException($"Received unexpected response: {response}");
                }

                byte[] bytes = _serialComm.ReadMany(4);

                var x = bytes[0] * 100 + bytes[1];
                var y = bytes[2] * 100 + bytes[3];

                Console.WriteLine($"X:{x} Y:{y}");
            }
        }

        public void EraseImage()
        {
            _serialComm.Write(NejeDk8KzConstants.EraseCommand, NejeDk8KzConstants.EraseCommand, NejeDk8KzConstants.EraseCommand, NejeDk8KzConstants.EraseCommand, NejeDk8KzConstants.EraseCommand, NejeDk8KzConstants.EraseCommand, NejeDk8KzConstants.EraseCommand, NejeDk8KzConstants.EraseCommand);
            //This sleep seems necessary to give the engraver enough time to process the erase
            //before we generate the image and send it to it.
            Thread.Sleep(NejeDk8KzConstants.SleepTime);
        }

        private byte[] GenerateImage(Stream imageStream)
        {
            var image = new Bitmap(imageStream);
            image.RotateFlip(RotateFlipType.RotateNoneFlipY);

            Bitmap workingBitmap = new Bitmap(512, 512);

            using (Graphics graphics = Graphics.FromImage((Image)workingBitmap))
            {
                graphics.FillRegion(new SolidBrush(Color.White), new Region(new Rectangle(0, 0, 512, 512)));

                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                //TODO: Find the correct transformation for the image
                //TODO: Resize images over 500 x 500
                //TODO: Test if 512 x 512 images can be used
                graphics.DrawImage(image,0,0);
            }

            byte[] byteArray = new byte[32830];

            using (MemoryStream memoryStream = new MemoryStream(byteArray))
            {
                var blackWhite = workingBitmap.Clone(
                    new Rectangle(0, 0, workingBitmap.Width, workingBitmap.Height), 
                    PixelFormat.Format1bppIndexed);

                blackWhite.Save(memoryStream, ImageFormat.Bmp);
            }

            return byteArray;
        }

        public void SendImage(Stream imageStream)
        {
            EraseImage();

            byte[] image = GenerateImage(imageStream);

            _serialComm.Write(image);
            //This sleep seems necessary to allow the machine to process the image
            Thread.Sleep(NejeDk8KzConstants.SleepTime);
        }

        public void SendImage(string pathToImage)
        {
            SendImage(File.OpenRead(pathToImage));
        }

        public decimal GetMinimumBurningTime()
        {
            return NejeDk8KzConstants.MinimumIntensity;
        }

        public decimal GetMaximumBurningTime()
        {
            return NejeDk8KzConstants.MaximumIntensity;
        }

        public void SetBurningTime(decimal intensity)
        {
            intensity = Math.Max(NejeDk8KzConstants.MinimumIntensity, Math.Min(intensity, NejeDk8KzConstants.MaximumIntensity));
            
            _serialComm.Write((byte) intensity);
        }
        
        public void Dispose()
        {
            _serialComm.Dispose();
        }
    }
}
