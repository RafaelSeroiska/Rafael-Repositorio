using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Exercicio_Fixacao_1._10
{
    class AlunosETurma
    {
        public static void Main32()
        {
            Turma t = new Turma();
            t.nomeTurma = "3º 1";
            t.nomeTurma = "2º 2";

            Alunos al = new Alunos();
            al.nome = "Osvardo";
            al.idade = 18;
            al.turma = t;

            Alunos al2 = new Alunos();
            al2.nome = "Asfranio";
            al2.idade = 28;

            Console.WriteLine(al.turma.nomeTurma);
            
             
        }
    }
}
