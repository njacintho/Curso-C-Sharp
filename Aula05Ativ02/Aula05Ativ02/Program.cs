using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05Ativ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o valor da compra: ");
            decimal valor = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Qunatidade de parcelas: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());


            decimal parcelas = valor / quantidade;

            Console.WriteLine("Ficaram {0} parcelas de {1:c}",quantidade, parcelas);
            Console.ReadLine();
        }
    }
}
