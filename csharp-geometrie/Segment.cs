using System;

namespace Eni.Geometrie
{
    class Segment : ICloneable
    {
        public Point Origine { get; set; }
        public Point Destination { get; set; }

        public double Longueur
        {
            get
            {
                return Math.Sqrt(
                    (Destination.X - Origine.X) * (Destination.X - Origine.X)
                    + (Destination.Y - Origine.Y) * (Destination.Y - Origine.Y)
                );
            }
        }

        public Segment()
        {

        }

        public Segment(Point origine, Point destination)
        {
            this.Origine = origine;
            this.Destination = destination;
        }

        internal void Deplacer(double dx, double dy)
        {
            Origine.Deplacer(dx,dy);
            Destination.Deplacer(dx, dy);
        }

        public override string ToString()
        {
            return String.Format("Segment[{0};{1};l={2}]", Origine, Destination, Longueur);
        }

        public object Clone()
        {
            return new Segment((Point)this.Origine.Clone(), (Point)this.Destination.Clone());
        }
    }
}
