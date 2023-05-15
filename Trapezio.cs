using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimetroAreaFiguras
{
    public class Trapezio
    {
        public double lado1 { get; set; }
        public double lado2 { get; set; }
        public double BaseMenor { get; set; }
        public double BaseMaior { get; set; }
        public double altura { get; set; }

        public double perimetro()
        {
            return BaseMaior + BaseMenor + lado1 + lado2;
        }

        public double Area()
        {
            return (BaseMaior + BaseMenor) * altura / 2;
        }

    }
}
