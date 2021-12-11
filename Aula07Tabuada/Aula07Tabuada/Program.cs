using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite a tabuada que deseja: ");
            int tabuada = Convert.ToInt32(Console.ReadLine());
            int multiplica;
            string valor = string.Empty;


            do {
                if(valor != string.Empty)
                {
                    tabuada = Convert.ToInt32(valor);
                }

                for (int i = 0; i <= 10; i++)
                {
                    multiplica = tabuada * i;
                    Console.WriteLine("{0} x {1} = {2}", tabuada, i, multiplica);
                }

                Console.WriteLine();
                Console.Write("Digite a tabuada que deseja ou enter para sair: ");
                valor = Console.ReadLine();
            }while(valor != string.Empty);

            Console.ReadLine();
        }
    }
}
