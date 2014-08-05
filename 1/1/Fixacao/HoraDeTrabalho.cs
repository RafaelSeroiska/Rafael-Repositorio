using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Fixacao
{
    class HoraDeTrabalho
    {
        static void Main33()
        {
            Console.WriteLine("Informe o salario do funcionario por hora trabalhada: ");
            double salario = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de horas: ");
            int horas = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            if (horas > 40)
            {
                    
                    salario = (salario * horas) * 0.50;
             }else
                    salario = salario * horas;
             Console.WriteLine(salario);
        }
    }
}
