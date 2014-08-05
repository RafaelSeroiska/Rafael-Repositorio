using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Fixacao
{
    class Estoque
    {
        static void Main11()
        {
            Console.WriteLine("Informe a quantidade atual em estoque: ");
            int estoque_atual = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a quantidade minima do estoque: ");
            int estoque_minima = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a quantidade maxima de estoque: ");
            int estoque_maxima = Convert.ToInt32(Console.ReadLine());

            int media_estoque = (estoque_maxima + estoque_minima) / 2;

            if (estoque_atual > media_estoque)
            {
                Console.WriteLine("Não efetuar compra: " + estoque_atual);
            }
            else
                Console.WriteLine("Efetuar compra: " + estoque_atual);
        }
    }
}
