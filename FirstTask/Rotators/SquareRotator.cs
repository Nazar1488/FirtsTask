using System;
using System.Drawing;
using FirstTask.Core;
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
                BottomLeft = PointProjector.Projection(PointRotator.Rotate(square.BottomLeft, rotatePoint, angleRad), square.BottomLeft, square.UpperLeft),
                BottomRight = PointProjector.Projection(PointRotator.Rotate(square.BottomRight, rotatePoint, angleRad), square.BottomRight, square.BottomLeft),
                UpperLeft = PointProjector.Projection(PointRotator.Rotate(square.UpperLeft, rotatePoint, angleRad), square.UpperLeft, square.UpperRight),
                UpperRight = PointProjector.Projection(PointRotator.Rotate(square.UpperRight, rotatePoint, angleRad), square.UpperRight, square.BottomRight)
            };
        }
    }
}
