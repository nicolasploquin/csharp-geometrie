using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eni.Geometrie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mon premier programme C# !");

            Point p1 = new Point();
            p1.X = 1.0;
            p1.Y = 2.0;

            Point p2 = new Point(2.0, 4.0);
            Point p3 = new Point3D(3.0,6.0,9.0);

            Console.WriteLine(p1);

            p1.Deplacer(104.0, 4.0);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Segment s1 = new Segment(p1, p3);

            Console.WriteLine(s1);

            s1.Deplacer(3.0, 5.0);

            Console.WriteLine(s1);





            Console.ReadLine();
        }
    }
}
