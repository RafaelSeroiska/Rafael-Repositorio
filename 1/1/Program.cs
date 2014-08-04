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
        static void Main11(string[] args)
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
            int valor_inicial = 0;
            int valor_atual = 0;
            int valor_final = 1;
            Console.WriteLine("Informe a quantidade de repeticao: ");
            int loopi = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < loopi; i++)
            {
                valor_atual = valor_inicial + valor_final;
                valor_inicial = valor_final;
                valor_final = valor_atual;
                
                Console.WriteLine(valor_atual);
            }
            Console.ReadKey();
        }      
    }
}