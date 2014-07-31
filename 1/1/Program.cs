using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        public static int v = 0;
        static void Main(string[] args)
        {
            //// 4)
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine("1 2 3 UM PASSITO PRA FRENTE, 1 2 3 UM PASSITO PRA TRAS");
            //}
            //// 5)
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //// 6)
            //for (int i = 1; i < 100; i++)
            //{
            //    int sobra = i % 2;
            //    if (sobra == 1)
            //    {
            //        Console.WriteLine(i + "*");
            //    }
            //    else
            //        Console.WriteLine(i + "**");
            //}
            //// 7)
            //for (int i = 0; i < 100; i++)
            //{
            //    int sobra = i % 4;
            //    if (sobra == 0)
            //    {
            //        Console.WriteLine("PI");
            //    }
            //    else
            //        Console.WriteLine(sobra);
            //}
            //// COMPLEMENTARES

            // 1)
            //string quant = "*";
            //string des = "   ";
            //string dos = "";
            //for (int linha = 0; linha < 5; linha++)
            //{
            //    Console.WriteLine("");
            //    for (int i = 0; linha > i; i++)
            //    {                    
            //     int resto = i % 2;
            //        if (resto == 1)
            //        {
            //            Console.Write(des+quant+des);
            //        }
            //        else
            //        {
            //            Console.Write(dos+quant+dos);
            //        }
            //    }

            //2)
        //    Console.WriteLine("Informe a repetição: ");
        //    int x = Convert.ToInt32(Console.ReadLine());
        //    string quant = "*";
        //    string des = "   ";
        //    string dos = "";
        //    for (int l = 0; l < x; l++)
        //    {
        //        for (int linha = 0; linha < 5; linha++)
        //        {
        //            Console.WriteLine("");
        //            for (int i = 0; linha > i; i++)
        //            {
        //                int resto = i % 2;
        //                if (resto == 1)
        //                {
        //                    Console.Write(des + quant + des);
        //                }
        //                else
        //                {
        //                    Console.Write(dos + quant + dos);
        //                }
        //            }
        //        }
        //    }
            Console.WriteLine("Digite o 1 valor do fibonacci: ");
            int primeiro_valor = Convert.ToInt32(Console.ReadLine());
            int proximo_valor = primeiro_valor + 1;
            int novo_valor = proximo_valor;

            Console.WriteLine("Informe a repetição de fibonacci: ");
            int repeticao = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < repeticao; i++)
            {
                int fibbo = novo_valor + proximo_valor;
                Console.WriteLine(fibbo);
            }

        }
    }
}