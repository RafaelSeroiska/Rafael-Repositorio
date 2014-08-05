using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Exercicio_Complementares.Orientacao_a_Objetos
{
    class TestaAluno
    {
        static void Main11()
        {
            Aluno aluno1 = new Aluno();
            aluno1.Nome = "Mano Lee Sin";
            aluno1.RG = 5972;
            aluno1.dataNascimento = "12/28/1996";

            Aluno aluno2 = new Aluno();
            aluno2.Nome = "Mana Orianna";
            aluno2.RG = 1200;
            aluno2.dataNascimento = "5/22/1993";

            Console.WriteLine(aluno1.Nome);
            Console.WriteLine(aluno1.RG);
            Console.WriteLine(aluno1.dataNascimento);

            Console.WriteLine(aluno2.Nome);
            Console.WriteLine(aluno2.RG);
            Console.WriteLine(aluno2.dataNascimento);
        }       
    }
}
