using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos
{
    class TestaCartaoDeCredito
    {
        public static void Main33()
        {
            CartaoDeCredito cdc1 = new CartaoDeCredito();
            cdc1.numero = 113456;
            cdc1.dataDeValidade = "12/17";

            CartaoDeCredito cdc2 = new CartaoDeCredito();
            cdc2.numero = 13134145;
            cdc2.dataDeValidade = "11/17";

            Console.WriteLine(cdc1.numero);
            Console.WriteLine(cdc1.dataDeValidade);

            Console.WriteLine(cdc2.numero);
            Console.WriteLine(cdc2.dataDeValidade);
        }
    }
}
