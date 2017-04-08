using System;
using System.Diagnostics;
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
        
        public void RestartMachine()
        {
            _serialComm.Write(NejeDk8KzConstants.RestartCommand);
        }

        public void PauseEngraving()
        {
            _serialComm.Write(NejeDk8KzConstants.PauseCommand);
        }

        public void StartEngraving()
        {
            _serialComm.Write(NejeDk8KzConstants.StartCommand);

            while (true)
            {
                var response = _serialComm.ReadOne();
                
                if (response == NejeDk8KzConstants.EngravingFinishedResponse)
                {
                    Debug.WriteLine($"Read machine response {response} is engravingFinished");
                    return;
                }

                if (response == NejeDk8KzConstants.PositionUpdatedResponse)
                {
                    Debug.WriteLine($"Read machine response {response} is position update");

                    byte[] bytes = _serialComm.ReadMany(4);

                    var x = bytes[0] * 100 + bytes[1];
                    var y = bytes[2] * 100 + bytes[3];

                    Debug.WriteLine($"X:{x} Y:{y}");
                }
                else
                {
                    Debug.WriteLine($"Read machine response {response} is unexpected response");
                    ////Unexpected response, abort!
                    //RestartMachine();
                    //throw new InvalidOperationException($"Received unexpected response: {response}");
                }

            }
        }

        public void EraseImage()
        {
            _serialComm.Write(NejeDk8KzConstants.EraseCommand, NejeDk8KzConstants.EraseCommand, NejeDk8KzConstants.EraseCommand, NejeDk8KzConstants.EraseCommand, NejeDk8KzConstants.EraseCommand, NejeDk8KzConstants.EraseCommand, NejeDk8KzConstants.EraseCommand, NejeDk8KzConstants.EraseCommand);
            //This sleep seems necessary to give the engraver enough time to process the erase
            //before we generate the image and send it to it.
            Thread.Sleep(NejeDk8KzConstants.SleepTime);
        }
        

        public void SendImage(byte[] image)
        {
            EraseImage();

            _serialComm.Write(image);
            //This sleep seems necessary to allow the machine to process the image
            Thread.Sleep(NejeDk8KzConstants.SleepTime);

            //This allows the carving area to be previewed before the actual engraving
            //Restart();
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
