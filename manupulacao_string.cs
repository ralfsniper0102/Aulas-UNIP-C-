using System;

namespace ConsoleApp1
{
    class Programa
    {
        static void Main(string[] args)
        {
            string frase = "Universidade Paulista";

            Console.WriteLine("A frase {0} possui {1} caracteres", frase, frase.Length);
            Console.WriteLine("Seus 3 primeiros caracteres são {0}", frase.Substring(0, 3));
            Console.WriteLine("E os seus ultimos 4 caracteres são {0}", frase.Substring(frase.Length - 4, 4));


        }
    }
}