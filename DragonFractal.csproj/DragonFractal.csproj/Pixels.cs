using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Fractals
{
    public class Pixels
    {

        private readonly ColorSwitch color = new ColorSwitch();

       // public readonly List<Tuple<double, double>> PixelsSet;
        public readonly List<DragonPoint> pixelList;

        public Pixels()
        {
          //  PixelsSet = new List<Tuple<double, double>>();
            pixelList = new List<DragonPoint>();
        }

        public void SetPixel(DragonPoint currentPixel)
        {
           // PixelsSet.Add(Tuple.Create(x, y));
            pixelList.Add(currentPixel);
        }

        public void DrawToBitmap(Bitmap image)
        {
            if (pixelList.Count == 0) return;

            double xMax = (double)pixelList.Max(p => p.xCoord);
            double yMax = (double)pixelList.Max(p => p.yCoord);
            double xMin = (double)pixelList.Min(p => p.xCoord);
            double yMin = (double)pixelList.Min(p => p.yCoord);

          /*  var maxX = PixelsSet.Max(p => p.Item1);
            var maxY = PixelsSet.Max(p => p.Item2);
            var minX = PixelsSet.Min(p => p.Item1);
            var minY = PixelsSet.Min(p => p.Item2);*/

            double width = xMax - xMin;
            double height = yMax - yMin;

            double scaleX = (image.Width - 20) / width;
            double scaleY = (image.Height - 20) / height;
            double scale = Math.Min(scaleX, scaleY);
            foreach (var pixel in pixelList)
            {
                double x = ((double)pixel.xCoord - xMin - width / 2) * scale + image.Width / 2.0;
                double y = ((double)pixel.yCoord - yMin - height / 2) * scale + image.Height / 2.0;
                image.SetPixel((int) x, (int) y, color.ColorSwitcher());
            }
        }
    }
}