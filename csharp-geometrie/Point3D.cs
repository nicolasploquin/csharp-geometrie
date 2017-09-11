
using System;

namespace Eni.Geometrie
{
    class Point3D : Point
    {
        public double Z { get; set; }

        public Point3D() : base()
        {

        }
        public Point3D(double x, double y, double z) : base(x,y)
        {
            Z += z;
        }

        public void Deplacer(double dx, double dy, double dz)
        {
            base.Deplacer(dx, dy);
            Z += dz;
        }

        public override string ToString()
        {
            return String.Format("Point3D({0:F1};{1:F1};{2:F1})", this.X, this.Y, this.Z);
        }
    }
}
