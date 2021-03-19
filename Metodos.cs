using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Programa
    {
        public static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            r.AumentaAltura(10);
            r.AumentaLargura(15);
            double area = r.CalculaArea();

            Console.WriteLine("A área do retângulo de altura {0} e largura {1} vale {2}", r.Altura, r.Largura, area);
            Console.ReadKey();
        }
    }
    class Retangulo
    {

        public double Largura = 0;
        public double Altura = 0;

        public double CalculaArea()
        {
            return Largura * Altura;
        }
        public void AumentaLargura(double l)
        {
            Largura += l;
        }

        public void AumentaAltura(double a)
        {
            Altura += a;
        }
    }
}