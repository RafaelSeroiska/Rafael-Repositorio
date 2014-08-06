using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Fixacao
{
    class Combustivel
    {
        public static double desconto,valor;
        static void Main()
        {
            Console.WriteLine("--- MENU COMPRA COMBUSTIVEL ---");
            Console.WriteLine("1 - G - GASOLINA");
            Console.WriteLine("2 - A - ALCOOL");
            int opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.WriteLine("Informe a quantidade a ser comprada de gasolina: ");
                    int g = Convert.ToInt32(Console.ReadLine());
                    if (g == 20)
                    {
                        desconto = 0.04;
                    }else
                        if (g > 20)
                        {
                          desconto = 0.06;
                        }
                    double valorGasolina = 3.30;

                    for (int i = 0; i < g; i++)
                    {
                         valor = desconto * valorGasolina;
                    }
                    Console.WriteLine("valor gasto: "+valor);
                        break;
                case 2:
                    Console.WriteLine("Informe a quantidade de alcool a ser comprada: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    if (a == 20)
                    {
                        desconto = 0.3;
                    }else
                        if (a > 20)
                        {
                           desconto = 0.5;
                        }

                    
                    double valorAlcool = 2.90;

                    for (int i = 0; i < a; i++)
                    {
                         valor = desconto * valorAlcool;
                    }
                    Console.WriteLine("valor gasto: "+valor);
                   
                    break;
                default:
                    Console.WriteLine("Só xora");
                    break;
            }
        }
    }
}
