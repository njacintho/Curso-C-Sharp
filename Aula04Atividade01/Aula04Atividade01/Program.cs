using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04Atividade01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, soma;

            Console.Write("Digite o número 1: ");
            n1 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Digite o número 2: ");
            n2 = Convert.ToInt32(Console.ReadLine());


            soma = n1 + n2;

            Console.WriteLine("A soma de {0} e {1} é {2}", n1, n2, soma);
            Console.ReadLine();

        }
    }
}
