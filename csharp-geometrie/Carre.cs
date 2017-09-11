using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eni.Geometrie
{
    class Carre
    {
        public Point Origine { get; set; }
        public double Cote { get; set; }

        public double Perimetre
        {
            get { return 4 * Cote; }
        }

        public double Aire
        {
            get { return Cote * Cote; }
        }


        public void Deplacer(double dx, double dy)
        {
            Origine.Deplacer(dx, dy);
        }
        public override string ToString()
        {
            return String.Format("Carre[{0},{1:F1},p={2:F3},a={3:F3}]", Origine, Cote, Perimetre, Aire);
        }
    }
}
