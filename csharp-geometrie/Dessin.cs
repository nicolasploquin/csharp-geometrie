using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eni.Geometrie
{
    class Dessin
    {
        private static Dessin _instance;

        public double Haut { get; private set; } = -100.0;
        public double Droite { get; private set; } = 100.0;
        public double Bas { get; private set; } = 100.0;
        public double Gauche { get; private set; } = -100.0;

        public static Dessin Instance
        {
            get {
                if (_instance == null) _instance = new Dessin();
                return _instance;
            }
        }

        private Dessin()
        {

        }

        public void DefinirCadre(double gauche, double haut, double droite, double bas)
        {
            Gauche = gauche;
            Haut = haut;
            Droite = droite;
            Bas = bas;
        }

        public void DefinirCadre(Point hautGauche, Point droiteBas)
        {
            Gauche = hautGauche.X;
            Haut = hautGauche.Y;
            Droite = droiteBas.X;
            Bas = droiteBas.Y;
        }


    }
}
