using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MECS.Core.Images
{
    public static class ImageHelper
    {
        public static Image EscaleImage(Image original, int canvasWidth, int canvasHeight, bool keepAspectRatio)
        {
            int originalWidth = original.Width;
            int originalHeight = original.Height;

            Image thumbnail = new Bitmap(canvasWidth, canvasHeight); // changed parm names
            System.Drawing.Graphics graphic = System.Drawing.Graphics.FromImage(thumbnail);

            graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphic.SmoothingMode = SmoothingMode.HighQuality;
            graphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphic.CompositingQuality = CompositingQuality.HighQuality;

            /* ------------------ new code --------------- */

            // Figure out the ratio
            double ratioX = (double)canvasWidth / (double)originalWidth;
            double ratioY = (double)canvasHeight / (double)originalHeight;


            if (keepAspectRatio)
            {
                // use whichever multiplier is smaller
                double ratio = ratioX < ratioY ? ratioX : ratioY;
                ratioX = ratio;
                ratioY = ratio;
            }

            // now we can get the new height and width
            int newHeight = Convert.ToInt32(originalHeight * ratioY);
            int newWidth = Convert.ToInt32(originalWidth * ratioX);

            // Now calculate the X,Y position of the upper-left corner 
            // (one of these will always be zero)
            int posX = Convert.ToInt32((canvasWidth - (originalWidth * ratioX)) / 2);
            int posY = Convert.ToInt32((canvasHeight - (originalHeight * ratioY)) / 2);

            graphic.Clear(Color.White); // white padding
            graphic.DrawImage(original, posX, posY, newWidth, newHeight);

            /* ------------- end new code ---------------- */

            return thumbnail;
        }
    }
}
