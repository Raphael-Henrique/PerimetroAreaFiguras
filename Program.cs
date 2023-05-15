using PerimetroAreaFiguras;
using System;

namespace PerimetroAreaFiguras
{
    class Program
    { 
        public static void Main(string[] args)
        {
            /*
                Criar um sistema que calcula o perímetro e a área de 3 figuras geométricas.   
             */

            Triangulo triangulo = new Triangulo();
            Quadrado quadrado = new Quadrado();
            Trapezio trapezio = new Trapezio();
            Circulo circulo = new Circulo();

            Console.Write("Digite o primeiro lado do triângulo: ");
            triangulo.lado1 = double.Parse(Console.ReadLine());
            Console.Write("\nDigite o segundo Lado do triângulo: ");
            triangulo.lado2 = double.Parse(Console.ReadLine());
            Console.Write("\nDigite a base do triângulo: ");
            triangulo.Base = double.Parse(Console.ReadLine());
            Console.Write("\nDigite a altura do triângulo: ");
            triangulo.altura = double.Parse(Console.ReadLine());


            Console.Clear();  

            Console.Write("Digite o lado do quadrado: ");
            quadrado.lado = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite o primeiro lado do trapézio: ");
            trapezio.lado1 = double.Parse(Console.ReadLine());
            Console.Write("\nDigite o segundo lado do trapézio: ");
            trapezio.lado2 = double.Parse(Console.ReadLine());
            Console.Write("\nDigite a base maior do trapézio: ");
            trapezio.BaseMaior = double.Parse(Console.ReadLine());
            Console.Write("\nDigite a base menor do trapézio: ");
            trapezio.BaseMenor = double.Parse(Console.ReadLine());
            Console.Write("\nDigite a altura do trapézio: ");
            trapezio.altura = double.Parse(Console.ReadLine());


            Console.Clear();

            Console.Write("Digite o raio do círculo: ");
            circulo.raio = double.Parse(Console.ReadLine());


            Console.Clear();

            Console.Write("O perímetro do triângulo é: " + triangulo.perimetro(triangulo.lado1, triangulo.lado2, triangulo.Base) + "cm");
            Console.Write("\nA área do triângulo é: " + triangulo.Area(triangulo.altura, triangulo.Base) + "cm");
            Console.Write("\n\nO perímetro do quadrado é: " + quadrado.Perimetro() + "cm");
            Console.Write("\nA área do quadrado é: " + quadrado.Area(quadrado.lado) + "cm");
            Console.Write("\n\nO perímetro do trapézio é: " + trapezio.perimetro() + "cm");
            Console.Write("\nA área do trapézio é: " + trapezio.Area() + "cm");
            Console.Write("\n\nO perímetro do círculo é: " + circulo.Perimetro(circulo.pi, circulo.raio) + "cm");
            Console.Write("\nA área do círculo é: " + circulo.Area() + "cm");
            Thread.Sleep(3000); 
        }
    }
}