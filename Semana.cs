using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Semana
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Vamos descobrir o dia da semana ao fornecer um número de 1 a 7!");
            Console.WriteLine("Digite um número:");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day) 
            { 
                case 1:
                    Console.WriteLine("Segunda-Feira");
                    break;
                case 2:
                    Console.WriteLine("Terça-Feira");
                    break;
                case 3:
                    Console.WriteLine("Quarta-Feira");
                    break;
                case 4:
                    Console.WriteLine("Quinta-Feira");
                    break;
                case 5:
                    Console.WriteLine("Sexta-Feira");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
            }
        }
    }
}
