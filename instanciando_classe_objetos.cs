using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Programa
    {
        public static void Main(string[]args)
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Joaquim";
            p1.Email = "joaquim@provedor.com";
            p1.Telefone = 123456789;

            Pessoa p2 = new Pessoa();
            p2.Nome = "Manoel";
            p2.Email = "manoel@provedor.com";
            p2.Telefone = 987654321;


            Console.WriteLine("Nome: {0}, E-mail: {1}, Telefone: {2}",p1.Nome, p1.Email, p1.Telefone);
            Console.WriteLine("Nome: {0}, E-mail: {1}, Telefone: {2}", p2.Nome, p2.Email, p2.Telefone);

            Console.ReadKey();
        }
    }
}
