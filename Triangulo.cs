using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimetroAreaFiguras
{
    public class Triangulo
    {
        public double lado1 { get; set; }
        public double lado2 { get; set; }
        public double Base { get; set; }
        public double altura { get; set; }
        
        public double Area(double altura, double Base)
        {
            return (Base * altura) / 2;
        }

        public double perimetro(double lado1, double lado2, double Base)
        {
            return lado1 + lado2 + Base;
        }

    }   
}
