using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eni.Geometrie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mon premier programme C# !");

            Dessin.Instance.DefinirCadre(-50.0, -50.0, 50.0, 50.0);

            Point p1 = new Point();
            p1.X = 1.0;
            p1.Y = 2.0;

            Point p2 = new Point(2.0, 4.0);
            Point p3 = new Point3D(3.0, 6.0, 9.0);
            Point p4 = new Point3D(4.0, 6.0, 9.0);

            Console.WriteLine(p4.ToString());

            Point p5 = (Point)p2.Clone();

            //Point[] tab = { p1, p2, p3, p4 };

            //foreach (Point p in tab)
            //{
            //    Console.WriteLine(p);
            //}

            Console.WriteLine(p1);

            p1.Deplacer(104.0, 4.0);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Segment s1 = new Segment(p1, p3);

            Console.WriteLine(s1);

            s1.Deplacer(3.0, 5.0);

            Console.WriteLine(s1);

            Carre ca1 = new Carre(p1, 5.0);
            Cercle ce1 = new Cercle(p2, 5.0);
            Triangle tri1 = new Triangle(p2, s1);
            Triangle tri2 = new Triangle(new Point(2.0,0.0), new Segment(new Point(0.0, 2.0), new Point(2.0, 2.0)));

            Figure[] tab = { ca1, ce1, tri1, tri2 };
            List<Figure> liste = tab.ToList<Figure>();
            Console.WriteLine(" --- tab --- ");
            foreach (Figure fig in tab)
            {
                Console.WriteLine(fig);
            }
            liste.Sort();
            Console.WriteLine(" --- liste triée --- ");
           foreach (Figure fig in liste)
            {
                Console.WriteLine(fig);
            }

            Console.WriteLine(ca1);


            p1.Afficher();
            ce1.Afficher();

            IAffichable[] listeDeChosesAffichables = { p1, ce1};
            foreach (IAffichable chose in listeDeChosesAffichables)
            {
                chose.Afficher();
            }


            Console.WriteLine(" --- Design Pattern Builder --- ");

            Figure fig3 = new FigureBuilder()
                .SetType(FigureType.CARRE)
                .AddPoint(p1)
                .SetLength(3.0)
                .Build();

            Figure fig4 = new FigureBuilder()
                .SetType(FigureType.TRIANGLE)
                .AddPoint(p1)
                .AddPoint(p2)
                .AddPoint(p3)
                .Build();

            FigureBuilder builder2 = new FigureBuilder(FigureType.CARRE);

            String str = new StringBuilder("test")
                .Append("A")
                .Append(123)
                .Append("B")
                .ToString();


            Console.WriteLine(fig3);
            Console.WriteLine(fig4);
            Console.WriteLine(str);

            Console.ReadLine();
        }
    }
}
