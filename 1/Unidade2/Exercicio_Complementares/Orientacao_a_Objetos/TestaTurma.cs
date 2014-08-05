using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Exercicio_Complementares.Orientacao_a_Objetos
{
    class TestaTurma
    {
        public static void Main22()
        {
            Turma t1 = new Turma();
            t1.periodo = "Noturno";
            t1.serie = "2° série";
            t1.tipoDeEnsino = "Matematica";
            t1.sigla = "Mat 2°";

            Turma t2 = new Turma();

            t2.periodo = "Matutino";
            t2.serie = "7° série";
            t2.tipoDeEnsino = "Fisica";
            t2.sigla = "Fis 7°";

            Console.WriteLine(t1.periodo);
            Console.WriteLine(t1.serie);
            Console.WriteLine(t1.sigla);
            Console.WriteLine(t1.tipoDeEnsino);

            Console.WriteLine("");

            Console.WriteLine(t2.periodo);
            Console.WriteLine(t2.serie);
            Console.WriteLine(t2.sigla);
            Console.WriteLine(t2.tipoDeEnsino);

        }
    }
}
