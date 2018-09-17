using System.Drawing;

namespace FirstTask.Core
{
    public static class PointProjector
    {
        public static PointF Projection(PointF point, PointF firstLinePoint, PointF secondLinePoint)
        {
            float[] coefficients =
            {
                firstLinePoint.Y - secondLinePoint.Y,
                secondLinePoint.X - firstLinePoint.X,
                firstLinePoint.X * secondLinePoint.Y - secondLinePoint.X * firstLinePoint.Y,
            };

            PointF normalVector = new PointF(secondLinePoint.X - firstLinePoint.X, secondLinePoint.Y - firstLinePoint.Y);

            float[] resultCoefficients =
            {
                normalVector.X,
                normalVector.Y,
                normalVector.X * -point.X + normalVector.Y * -point.Y
            };

            float resultX = -((coefficients[2] * resultCoefficients[1] - resultCoefficients[2] * coefficients[1]) /
                              (coefficients[0] * resultCoefficients[1] - resultCoefficients[0] * coefficients[1]));
            float resultY = -((coefficients[0] * resultCoefficients[2] - resultCoefficients[0] * coefficients[2]) /
                              (coefficients[0] * resultCoefficients[1] - resultCoefficients[0] * coefficients[1]));
            return new PointF(resultX, resultY);
        }
    }
}
