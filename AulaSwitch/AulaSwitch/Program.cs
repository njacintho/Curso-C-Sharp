using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hora = DateTime.Now.Hour;
            string mensagem = string.Empty;
            switch (hora)
            {
                case 10:
                case 15:
                    mensagem = "Hora do intervalo";
                    break;
                case 12:
                    mensagem = "Alomoço";
                    break;
                case 19:
                    mensagem = "Estudos";
                    break ;
                default:
                    mensagem = string.Empty;
                    break;
            }
            Console.ReadLine();
        }
    }
}
