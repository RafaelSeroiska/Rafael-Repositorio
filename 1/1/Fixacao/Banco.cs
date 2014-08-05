using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Fixacao
{
    class Banco
    {
        public static Random randNum = new Random();
        static void Main333()
        {
            Console.WriteLine("informe o numero da conta: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            int saldo = randNum.Next(1, 10000);
            int credito = randNum.Next(1, 1000);
            int debito = randNum.Next(1, 1000);
            int saldo_atual = saldo - debito + credito;

            if (saldo_atual < 0)
            {
                Console.WriteLine("Saldo negativo: " + saldo_atual);
            }
            else
                Console.WriteLine("Saldo positivo: " + saldo_atual);
        }
    }
}
