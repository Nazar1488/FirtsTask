using System.Drawing;
using FirstTask.Core.Models;

namespace FirstTask.Builders
{
    public static class SquareBuilder
    {
        public static Square Build(float upperLeftX, float upperLeftY, float sideLength)
        {
            return new Square
            {
                UpperLeft = new PointF(upperLeftX, upperLeftY),
                UpperRight = new PointF(upperLeftX + sideLength, upperLeftY),
                BottomLeft = new PointF(upperLeftX, upperLeftY + sideLength),
                BottomRight = new PointF(upperLeftX + sideLength, upperLeftY + sideLength)
            };
        }
    }
}
