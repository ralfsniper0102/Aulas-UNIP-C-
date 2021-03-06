using System;

namespace teste
{
    class Programa
    {
        static void Main(string[] args)
        {
            double numero = 0;
            Console.Write("Digite um numero: ");
            numero = Convert.ToDouble(Console.ReadLine());


            if (numero % 2 == 0 && numero > 5)
            {
                Console.WriteLine("o número {0} é par e maior que 5", numero);
            }
            else if (numero % 2 == 0 && numero < 5)
            {
                Console.WriteLine("o número {0} é par e menor que 5", numero);
            }
            else if (numero==5)
            {
                Console.WriteLine("o número é 5 e é impar");
            }
            else if (numero > 5)
            {
                Console.WriteLine("o número {0} é impar e maior que 5", numero);
            }
            else
            {
                Console.WriteLine("o número {0} é impar e menor que 5", numero);
            }
            Console.ReadKey();
        }
    }
}
