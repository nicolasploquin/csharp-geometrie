using System;

namespace Eni.Geometrie
{
    public class Point
    {

        public static double Haut { get; private set; } = -100.0;
        public static double Droite { get; private set; } = 100.0;
        public static double Bas { get; private set; } = 100.0;
        public static double Gauche { get; private set; } = -100.0;

        private double _x = 0.0;
        private double _y = 0.0;

        public double X
        {
            get { return _x; }
            set
            {
                if (value < Point.Gauche) _x = Point.Gauche;
                else if (value > Point.Droite) _x = Point.Droite;
                else _x = value;
            }
        }
        public double Y
        {
            get { return _y; }
            set
            {
                if (value < Point.Haut) _y = Point.Haut;
                else if (value > Point.Bas) _y = Point.Bas;
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

        public static void DefinirCadre(double gauche, double haut, double droite, double bas)
        {
            Gauche = gauche;
            Haut = haut;
            Droite = droite;
            Bas = bas;
        }

        public static void DefinirCadre(Point hautGauche, Point droiteBas)
        {
            Gauche = hautGauche.X;
            Haut = hautGauche.Y;
            Droite = droiteBas.X;
            Bas = droiteBas.Y;
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
