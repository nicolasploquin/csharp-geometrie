using System;

namespace Eni.Geometrie
{
    internal class Cercle : Figure, IAffichable, IAfficher
    {
        public Point Centre { get; set; }
        public double Rayon { get; set; }

        public override double Perimetre => Math.PI * Rayon * 2;

        public override double Aire => Math.PI * Rayon * Rayon;

        public Cercle()
        {

        }

        public Cercle(Point centre, double rayon)
        {
            this.Centre = centre;
            this.Rayon = rayon;
        }

        public override void Deplacer(double dx, double dy)
        {
            Centre.Deplacer(dx,dy);
        }

        public override string ToString()
        {
            return String.Format("Cercle[{0};{1:F1};p={2:F3};a={3:F3}]", Centre, Rayon, Perimetre, Aire);
        }

        public void Afficher()
        {
            Console.WriteLine("Ceci est un cercle : {0}", this);
        }
    }
}