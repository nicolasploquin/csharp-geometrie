using Eni.Util;
using System;
using System.Collections.Generic;

namespace Eni.Geometrie
{
    public class Point : Observable, IAffichable, ICloneable
    {
        // public const int NOMBRE = 12;

        private double _x = 0.0;
        private double _y = 0.0;

        private Dessin dessin = Dessin.Instance;

        public double X
        {
            get { return _x; }
            set
            {
                if (value < dessin.Gauche) _x = dessin.Gauche;
                else if (value > dessin.Droite) _x = dessin.Droite;
                else _x = value;
                NotifyAll();
            }
        }

        public double Y
        {
            get { return _y; }
            set
            {
                if (value < dessin.Haut) _y = dessin.Haut;
                else if (value > dessin.Bas) _y = dessin.Bas;
                else _y = value;
                NotifyAll();
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

        public void Afficher()
        {
            Console.WriteLine("Ceci est un point : {0}", this);
        }

        public object Clone()
        {
            return new Point(this.X,this.Y);
        }

    }
}
