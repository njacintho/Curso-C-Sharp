using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06Ativ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal valorCompra;
            int numeroParcelas = 3;
            decimal valorParcela;
            decimal valorMinimoParcelar = 1000.0m;

            Console.Write("Digite o valor da compra:");
            valorCompra = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Valor a vista: {0:c}",valorCompra);

            if(valorCompra > valorMinimoParcelar)
            {
                valorParcela = valorCompra / numeroParcelas;

                Console.WriteLine("Pode ser parcelado em {0} vezes. Valor da Parcela:{1:c}",
                    numeroParcelas,valorParcela);
            }


            Console.ReadLine();
        }
    }
}
