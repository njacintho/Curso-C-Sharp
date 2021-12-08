using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipos primitivos");

            string nome = "Maria";

            short numPequeno = 100; // é igual System.Int16
            int numero = 20; // é igual System.Int32 
            long numGrande = 1200000; // é igual System.Int64


            byte item = 20;

            double comissao = 32.456787889;
            decimal valor = Convert.ToDecimal(1000.56);
            decimal valor1 = 1000.56m; // o m é mesma coisa do convert.todeciaml

            // para datas
            DateTime data = DateTime.Now;
            Console.WriteLine(data); // mostra a data atual com a hora
            DateTime dataExemplo = new DateTime(2050, 12, 31);

            

            //formatar 


            Console.WriteLine("{0:d}", dataExemplo); // d maior msotra da data abreviada 31/12/2050
            Console.WriteLine("{0:D}", dataExemplo); // D menor mostra da data por extenso
            Console.WriteLine("{0:ddd}", dataExemplo); // tres ddd mostra o dia da semna abreviado sab
            Console.WriteLine("{0:dddd}", dataExemplo);// quatro dddd mostra o dia da semana por extenso 


            Console.WriteLine("{0:c}", valor1); // c formato moeda com o R$.

            Console.ReadLine();
        }
    }
}
