using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Exercicio_Fixacao_METODOS
{
    class TestaConta
    {
        public static void Main11()
        {
            Conta c = new Conta();
            c.Deposita(1000);
            c.ImprimeExtrato();
            c.Saca(100);
            c.ImprimeExtrato();

            double saldoDisponivel = c.ConsultaSaldoDisponivel();
            Console.WriteLine("Saldo disponivel: " + saldoDisponivel);
        }
    }
}
