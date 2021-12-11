using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  For 
             *  
            for(int i = 1; i <= 10 ; i++)
            {
                Console.WriteLine(i);
            }
            */


            /* While
             * 
            int x = 1;
            while(x <= 10)
            {
                Console.WriteLine(x);
                x++;
            }*/


            string senha = "123";
            string senhaInformada = string.Empty;

            do
            {
                Console.Write("Digite a senha: ");
                senhaInformada = Console.ReadLine();
                if(senhaInformada != senha)
                {
                    Console.WriteLine("Senha incorreta");
                }
            }while(senhaInformada != senha);

            /*
            while (senha != senhaInformada)
            {
                Console.Write("Digite a senha: ");
                senhaInformada = Console.ReadLine();
            }
            */

            Console.WriteLine("fim");
            Console.ReadLine();
        }
    }
}
