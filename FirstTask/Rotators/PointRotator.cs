using System;
using System.Drawing;

namespace FirstTask.Rotators
{
    public static class PointRotator
    {
        public static PointF Rotate(PointF point, PointF rotatePoint, double angle)
        {
            var x = Convert.ToSingle((point.X - rotatePoint.X) * Math.Cos(angle) - (point.Y - rotatePoint.Y) * Math.Sin(angle) + rotatePoint.X);
            var y = Convert.ToSingle((point.X - rotatePoint.X) * Math.Sin(angle) + (point.Y - rotatePoint.Y) * Math.Cos(angle) + rotatePoint.Y);
            
            return new PointF(x, y);
        }
    }
}
