using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eni.Geometrie
{
    class FigureBuilder
    {
        private Figure _figure;

        private List<Point> _points = new List<Point>();
        private List<double> _length = new List<double>();

        public FigureBuilder()
        {

        }

        public FigureBuilder(FigureType type)
        {
            this.SetType(type);
        }
        public FigureBuilder SetType(FigureType type)
        {

            switch (type)
            {
                case FigureType.TRIANGLE:
                    _figure = new Triangle();
                    break;
                case FigureType.CARRE:
                    _figure = new Carre();
                    break;
                case FigureType.CERCLE:
                    _figure = new Cercle();
                    break;
            }
            return this;
        }

        public FigureBuilder AddPoint(Point pt)
        {
            _points.Insert(0, pt);
            return this;

        }

        public FigureBuilder SetLength(double len)
        {
            _length.Insert(0,len);
          return this;
        }

        public Figure Build()
        {
            if (_figure == null)
            {
                throw new Exception("Type de la figure indéfini.");
            }
            else if (_figure is Carre)
            {
                Carre fig = (Carre)_figure;
                if (_points.Count >= 1) fig.Origine = _points[0];
                if (_length.Count >= 1) fig.Cote = _length[0];
            }
            else if (_figure is Cercle)
            {
                Cercle fig = (Cercle)_figure;
                if (_points.Count >= 1) fig.Centre = _points[0];
                if (_length.Count >= 1) fig.Rayon = _length[0];
            }
            else if (_figure is Triangle)
            {
                if (_points.Count >= 3)
                {
                    _figure = new Triangle(_points[0], new Segment(_points[1], _points[2]));
                }
                else
                {
                    throw new Exception("Nombre de points insuffisant pour construire un triangle.");
                }
            }

            return _figure;
        }

    }
}
