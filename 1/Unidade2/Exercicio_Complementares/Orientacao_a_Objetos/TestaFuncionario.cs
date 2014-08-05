using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Exercicio_Complementares.Orientacao_a_Objetos
{
    class TestaFuncionario
    {
        public static void Main22() {
            Funcionario funcionario1 = new Funcionario();

            funcionario1.Nome = "Blitzkriegpop";
            funcionario1.Cargo = "Professor";
            funcionario1.cargoFuncionario = " Quimica, Fisica,Matemática";

            Funcionario funcionario2 = new Funcionario();

            funcionario2.Nome = "Raimunda";
            funcionario2.Cargo = "Auxiliar de limpeza";
            funcionario2.cargoFuncionario = "Limpar colégio";


            Console.WriteLine(funcionario1.Nome);
            Console.WriteLine(funcionario1.Cargo);
            Console.WriteLine(funcionario1.cargoFuncionario);

            Console.WriteLine("");
            Console.WriteLine(funcionario2.Nome);
            Console.WriteLine(funcionario2.Cargo);
            Console.WriteLine(funcionario2.cargoFuncionario);
        
        }
    }
}
