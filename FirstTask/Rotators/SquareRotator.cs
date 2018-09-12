using System;
using System.Drawing;
using FirstTask.Core.Models;

namespace FirstTask.Rotators
{
    public static class SquareRotator
    {
        public static Square Rotate(Square square, PointF rotatePoint, int angle)
        {
            var angleRad = angle * Math.PI / 180;
            return new Square
            {
                BottomLeft = PointRotator.Rotate(square.BottomLeft, rotatePoint, angleRad),
                BottomRight = PointRotator.Rotate(square.BottomRight, rotatePoint, angleRad),
                UpperLeft = PointRotator.Rotate(square.UpperLeft, rotatePoint, angleRad),
                UpperRight = PointRotator.Rotate(square.UpperRight, rotatePoint, angleRad),
            };
        }
    }
}
