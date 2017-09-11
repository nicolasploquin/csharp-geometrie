using System;

namespace Eni.Geometrie
{
    public class Point
    {

        private double _x = 0.0;
        private double _y = 0.0;

        public double X
        {
            get { return _x; }
            set
            {
                if (value < 0.0) _x = 0.0;
                else if (value > 100.0) _x = 100.0;
                else _x = value;
            }
        }
        public double Y
        {
            get { return _y; }
            set
            {
                if (value < 0.0) _y = 0.0;
                else if (value > 100.0) _y = 100.0;
                else _y = value;
            }
        }

        public Point()
        {

        }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Deplacer(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }


        public override string ToString()
        {
            return String.Format("Point({0:F1};{1:F1})", this.X, this.Y);
        }
       

    }
}
