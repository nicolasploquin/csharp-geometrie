using System;

namespace Eni.Geometrie
{
    internal class Triangle : Figure
    {
        public Point Sommet { get; set; }
        public Segment Base { get; set; }

        public override double Perimetre
        {
            get
            {
                return Base.Longueur
                        + new Segment(Base.Origine, Sommet).Longueur
                        + new Segment(Base.Destination, Sommet).Longueur;
            }
        }
           

        /** 
         * par déterminant de deux vecteurs : abs| (xb-xa)*(yc-ya) - (xc-xa)*(yb-ya) | / 2 
         * a sommet ; b base origine ; c base destination
         */
        public override double Aire
        {
            get
            {
                return Math.Abs((Base.Origine.X - Sommet.X) * (Base.Destination.Y - Sommet.Y)
                      - (Base.Destination.X - Sommet.X) * (Base.Origine.Y - Sommet.Y)) / 2.0;
            }
        }
            

        public Triangle()
        {

        }

        public Triangle(Point sommet, Segment _base)
        {
            this.Sommet = sommet;
            this.Base = _base;
        }
        public override void Deplacer(double dx, double dy)
        {
            Sommet.Deplacer(dx, dy);
            Base.Deplacer(dx, dy);
        }

        public override string ToString()
        {
            return String.Format("Triangle[{0};{1};p={2:F3};a={3:F3}]", Sommet, Base, Perimetre, Aire);
        }

     }
}