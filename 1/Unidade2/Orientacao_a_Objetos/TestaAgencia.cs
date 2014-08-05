using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos
{
    class TestaAgencia
    {
        public static void Main3()
        {
            Agencia agencia = new Agencia();

            agencia.numero = 12314;

            Agencia agencia2 = new Agencia();
            agencia2.numero = 1213134;

            Console.WriteLine(agencia.numero);
            Console.WriteLine(agencia2.numero);
        }
    }
}
