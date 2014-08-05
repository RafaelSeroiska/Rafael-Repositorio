using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos
{
    class TestaValoresPadrao
    {
        static void Main3()
        {
            Conta c = new Conta();
            Console.WriteLine(c.limite);
            Console.WriteLine(c.numero);
            Console.WriteLine(c.saldo);
        }
    }
}
