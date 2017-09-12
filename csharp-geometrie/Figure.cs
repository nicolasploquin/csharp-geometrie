using System;

namespace Eni.Geometrie
{
    public abstract class Figure : IComparable<Figure>
    {
        public abstract double Perimetre { get; }
        public abstract double Aire { get; }

        public int CompareTo(Figure other)
        {
            return (this.Perimetre - other.Perimetre)<=0.0 ? -1 : 1;
        }

        public abstract void Deplacer(double dx, double dy);



    }
}
