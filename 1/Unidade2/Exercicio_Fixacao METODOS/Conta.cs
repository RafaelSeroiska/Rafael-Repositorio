using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Exercicio_Fixacao_METODOS
{
    class Conta
    {
        public int numero;
        public double saldo;
        public double limite = 100;
        //public Agencia agencia;

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }
        public void Saca(double valor)
        {
            this.saldo -= valor;
        }
        public void ImprimeExtrato()
        {
            Console.WriteLine("Saldo: " + this.saldo);
        }
        public double ConsultaSaldoDisponivel()
        {
            return this.saldo + this.limite;
        }
    }
}
