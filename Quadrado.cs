using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimetroAreaFiguras
{
    public class Quadrado
    {
        public double lado;

        public double Perimetro()
        {
            return lado * 4;
        }

        public double Area(double lado)
        {
            return lado * lado;
        }

    }
}