using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05Ativ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do produto: ");
            decimal valor = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digitw a quantidade de produtos: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            decimal resultado = valor * quantidade;

            Console.Write("O total da compra é: {0:c}",resultado);
            Console.ReadLine();
        }
    }
}
