using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Fixacao
{
    class Xadrez
    {
        static void Main11(){
            Console.WriteLine("informe a hora de inicio do jogo: ");
            int hora_inicial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("informe a hora final do jogo");
            int hora_final = Convert.ToInt32(Console.ReadLine());
            if (hora_final - hora_inicial > 24)
            {
                Console.WriteLine("ultrapassou 24hrs");
            }
            else
                Console.WriteLine("Nao ultrapassou 24hrs.");
            if (hora_final < hora_inicial)
            {
                Console.WriteLine("Ultrapassou um dia de jogo");
                Console.WriteLine(hora_inicial);
                Console.WriteLine(hora_final);
            }
            else
                Console.WriteLine("Nao ultrapassou um dia de jogo");

        }
    }
}
