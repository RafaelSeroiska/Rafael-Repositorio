using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos
{
    class TestaConta
    {
        static void Main3()
        {
            Conta c1 = new Conta();
            c1.limite = 500;
            c1.numero = 1;
            c1.saldo = 1000;

            Conta c2 = new Conta();
            c2.limite = 100;
            c2.numero = 2;
            c2.saldo = 2000;

            Conta c3 = new Conta();

            c3.limite = 800;
            c3.numero = 3;
            c3.saldo = 3000;


            Console.WriteLine(c1.limite);
            Console.WriteLine(c1.numero);
            Console.WriteLine(c1.saldo);


            Console.WriteLine(c2.limite);
            Console.WriteLine(c2.numero);
            Console.WriteLine(c2.saldo);


            Console.WriteLine(c3.limite);
            Console.WriteLine(c3.numero);
            Console.WriteLine(c3.saldo);
        }
    }
}
