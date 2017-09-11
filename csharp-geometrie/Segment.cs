using System;

namespace Eni.Geometrie
{
    class Segment
    {
        public Point Origine { get; set; }
        public Point Destination { get; set; }

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
            return String.Format("Segment[{0},{1}]", Origine, Destination);
        }

    }
}
