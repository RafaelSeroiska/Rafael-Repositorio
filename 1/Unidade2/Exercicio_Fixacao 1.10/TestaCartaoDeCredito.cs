using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Exercicio_Fixacao_1._10
{
    class TestaCartaoDeCredito
    {
        static void Main33() 
        {

            // criando objetos
            CartaoDeCredito cdc1 = new CartaoDeCredito();

            cdc1.numero = 13193838;
            cdc1.dataValidade = "07/21";

            // populando objetos

            Cliente c = new Cliente();

            c.codigo = 128189;
            c.nome = "Astolfo";

            // populando denovo

            CartaoDeCredito cdc2 = new CartaoDeCredito();

            cdc2.numero = 12982;
            cdc2.dataValidade = "02/19";

            //ligando os objetos

            cdc2.cliente = c;

            Console.WriteLine(cdc2.numero); ;
            Console.WriteLine(cdc2.dataValidade);
            Console.WriteLine(cdc2.cliente.nome);


        }
    }
}
