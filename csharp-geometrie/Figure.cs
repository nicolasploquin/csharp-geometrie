using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eni.Geometrie
{
    public abstract class Figure
    {
        public abstract double Perimetre { get; }
        public abstract double Aire { get; }

        public abstract void Deplacer(double dx, double dy);



    }
}
