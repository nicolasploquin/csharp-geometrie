using Eni.Util;
using System;
using System.ComponentModel;

namespace Eni.Geometrie
{
    public class Segment : ICloneable, IObserver
    {
        private Point _origine;
        private Point _destination;


        public Point Origine
        {
            get
            {
                return _origine;
            }
            set
            {
                _origine = value;
                _origine.Subscribe(this);
            }
        }

        public Point Destination
        {
            get
            {
                return _destination;
            }
            set
            {
                _destination = value;
                _destination.Subscribe(this);
            }
        }

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

        public void Update()
        {
            Console.WriteLine("Segment modifié : {0}", this);
        }

    }
}
