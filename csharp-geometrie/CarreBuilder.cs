using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eni.Geometrie
{
    class CarreBuilder
    {
        private Carre _carre;

        public CarreBuilder()
        {
            _carre = new Carre();
        }

        public CarreBuilder SetOrigine(Point pt)
        {
            _carre.Origine = pt;
            return this;
        }

        public CarreBuilder SetCote(double len)
        {
            _carre.Cote = len;
            return this;
        }


        public CarreBuilder LoadCSV(string filename)
        {
            // ...

            return this;
        }


        public Carre Build()
        {
            return _carre;
        }

    }
}
