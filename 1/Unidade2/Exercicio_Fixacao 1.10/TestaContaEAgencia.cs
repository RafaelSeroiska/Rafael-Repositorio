using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Exercicio_Fixacao_1._10
{
    class TestaContaEAgencia
    {
        static void Main11()
        {
            Agencia a = new Agencia();
            a.numero = 1919;


            ContaAgencia c1 = new ContaAgencia();
            c1.numero = 12189;
            c1.saldo = 1000;
            c1.limite = 500;

            c1.agencia = a;

            Console.WriteLine(c1.numero);
            Console.WriteLine(c1.saldo);
            Console.WriteLine(c1.limite);
            Console.WriteLine(c1.agencia.numero);


        }
    }
}
