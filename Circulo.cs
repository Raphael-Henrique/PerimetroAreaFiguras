using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimetroAreaFiguras
{
    public class Circulo
    {
        public double pi;
        public double raio;


        public double Perimetro(double pi, double raio)
        {
            pi = 3.14;
            return 2 * pi * raio;
        }

        public double Area()
        {
            pi = 3.14;
            return pi * (raio * raio);
        }
    }
}
