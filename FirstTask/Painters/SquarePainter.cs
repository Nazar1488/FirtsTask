using System.Collections.Generic;
using System.Drawing;
using FirstTask.Core.Models;

namespace FirstTask.Painters
{
    public static class SquarePainter
    {

        public static Bitmap Paint(Square square, Pen pen, int imageWidth, int imageHeight)
        {
            var image = new Bitmap(imageWidth, imageHeight);
            var graphics = Graphics.FromImage(image);
            graphics.DrawLine(pen, square.UpperLeft, square.UpperRight);
            graphics.DrawLine(pen, square.UpperLeft, square.BottomLeft);
            graphics.DrawLine(pen, square.BottomLeft, square.BottomRight);
            graphics.DrawLine(pen, square.BottomRight, square.UpperRight);
            return image;
        }

        public static Bitmap Paint(List<Square> squares, Pen pen, int imageWidth, int imageHeight)
        {
            var image = new Bitmap(imageWidth, imageHeight);
            var graphics = Graphics.FromImage(image);
            foreach (var square in squares)
            {
                graphics.DrawLine(pen, square.UpperLeft, square.UpperRight);
                graphics.DrawLine(pen, square.UpperLeft, square.BottomLeft);
                graphics.DrawLine(pen, square.BottomLeft, square.BottomRight);
                graphics.DrawLine(pen, square.BottomRight, square.UpperRight);
            }

            return image;
        }
    }
}
