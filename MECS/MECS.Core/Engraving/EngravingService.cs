using MECS.Core.Contracts;
using MECS.Core.Images;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Ports;
using System.Text;

namespace MECS.Core.Engraving
{
    public class EngravingService
    {
        private IEngraver _engraver;
        private decimal _burningTime;
        private EngraverFactory _engraverFactory = new EngraverFactory();
        private Image _pictureOriginal;
        private Image _pictureToMachine;
        private Image _pictureOriginalToDisplay;
        private Image _pictureToMachineToDisplay;

        public Type[] GetAvaliableDrivers()
        {
            return new[]
            {
                typeof(NejeDk8KzEngraver),
                typeof(MockEngraver)
            };
        }

        public string[] GetAvailablePorts()
            => SerialPort.GetPortNames();

        public void ConnectToEngraver(Type driverType, string portName)
        {
            _engraver = _engraverFactory.Build(driverType, portName);
        }

        public void DisconnectFromEngraver()
        {
            _engraver?.Dispose();
        }

        public void MoveToOrigin()
        {
            _engraver?.MoveToOrigin();
        }

        public void MoveToCenter()
        {
            _engraver?.MoveToCenter();
        }

        public void Preview()
        {
            _engraver?.Preview();
        }

        public void MoveUp()
        {
            _engraver?.MoveUp();
        }

        public void MoveLeft()
        {
            _engraver?.MoveLeft();
        }

        public void MoveDown()
        {
            _engraver?.MoveDown();
        }

        public void MoveRight()
        {
            _engraver?.MoveRight();
        }

        public decimal GetMinimumBurningTime()
        {
            return _engraver?.GetMinimumBurningTime() ?? 0;
        }

        public decimal GetMaximumBurningTime()
        {
            return _engraver?.GetMaximumBurningTime() ?? 0;
        }

        public void SetBurningTime(decimal burningTime)
        {
            _burningTime = burningTime;
        }

        public void PauseEngraving()
        {
            _engraver?.PauseEngraving();
        }

        public void RestartMachine()
        {
            _engraver?.RestartMachine();
        }

        public void SendImageToMachine()
        {
            if(_engraver == null)
            {
                return;
            }

            byte[] image = new byte[32830];

            using (var memorystream = new MemoryStream(image))
            {
                _pictureToMachine.Save(memorystream, ImageFormat.Bmp);
            }

            _engraver.SendImage(image);
        }

        public IEnumerable<EngraverPosition> EngravePicture()
        {
            _engraver.SetBurningTime(_burningTime);

            return _engraver.StartEngraving();
        }

        public void LoadOriginalPicture(string path)
        {
            var pictureBeingProcessed = new Bitmap(path);

            LoadOriginalPicture(pictureBeingProcessed);
        }

        public void LoadOriginalPicture(Bitmap originalPicture)
        {
            _pictureOriginal = originalPicture;
        }

        public void CalculatePictureToBeProcessed(bool stretchPicture, bool keepAspectRatio)
        {
            if (stretchPicture)
            {
                _pictureOriginalToDisplay = ImageHelper.EscaleImage(
                    _pictureOriginal,
                    512,
                    512,
                    keepAspectRatio);
            }
            else
            {
                _pictureOriginalToDisplay = (Bitmap)_pictureOriginal.Clone();
            }

            Bitmap workingBitmap = new Bitmap(512, 512);

            using (Graphics graphics = Graphics.FromImage((Image)workingBitmap))
            {
                graphics.FillRegion(new SolidBrush(Color.White), new Region(new Rectangle(0, 0, 512, 512)));

                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                Image img = (Image)_pictureOriginalToDisplay.Clone();

                img.RotateFlip(RotateFlipType.Rotate180FlipX);

                graphics.DrawImage(img, 0, 0);
            }

            _pictureToMachine = workingBitmap.Clone(
                new Rectangle(0, 0, workingBitmap.Width, workingBitmap.Height),
                PixelFormat.Format1bppIndexed);

            Bitmap workingBitmap2 = new Bitmap(512, 512);

            using (Graphics graphics = Graphics.FromImage((Image)workingBitmap2))
            {
                graphics.FillRegion(new SolidBrush(Color.White), new Region(new Rectangle(0, 0, 512, 512)));

                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                Image img = (Image)_pictureOriginalToDisplay.Clone();

                graphics.DrawImage(img, 0, 0);
            }

            _pictureToMachineToDisplay = workingBitmap2.Clone(
                new Rectangle(0, 0, workingBitmap.Width, workingBitmap.Height),
                PixelFormat.Format1bppIndexed);
        }

        public Image GetOriginalImage()
        {
            return _pictureOriginalToDisplay;
        }

        public Image GetWorkingImage()
        {
            return _pictureToMachineToDisplay;
        }
    }
}
