﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número de 1 a 10: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 1 || n > 10)
            {
                Console.WriteLine("O número não está dentro do range");
            }
            else
            {
                Console.WriteLine("Obrigado");
            }
            Console.ReadLine();
        }
    }
}
