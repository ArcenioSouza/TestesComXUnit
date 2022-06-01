using System;
using Ex7Funcionarios.Model;

namespace Ex7Funcionarios
{
    public class ProgramFuncionarios
    {
        public static void Main()
        {
            Gerente f1 = new Gerente("Paulo", 27, 4000);
            Supervisor f2 = new Supervisor("José", 35, 3000);
            Vendedor f3 = new Vendedor("Samuel", 30, 2000);

            Console.WriteLine("Funcionários antes da bonificação");
            Console.WriteLine("Gerente: " + f1.Nome + ", " + f1.Idade + " anos," + " Salário: R$" + f1.Salario);
            Console.WriteLine("Supervisor: " + f2.Nome + ", " + f2.Idade + " anos," + " Salário: R$" + f2.Salario);
            Console.WriteLine("Vendedor: " + f3.Nome + ", " + f3.Idade + " anos," + " Salário: R$" + f3.Salario);
            Console.WriteLine("--------------------------------------");

            f1.Bonificacao();
            f2.Bonificacao();
            f3.Bonificacao();

            Console.WriteLine("Funcionários depois da bonificação");
            Console.WriteLine("Gerente: " + f1.Nome + ", " + f1.Idade + " anos," + " Salário: R$" + f1.Salario);
            Console.WriteLine("Supervisor: " + f2.Nome + ", " + f2.Idade + " anos," + " Salário: R$" + f2.Salario);
            Console.WriteLine("Vendedor: " + f3.Nome + ", " + f3.Idade + " anos," + " Salário: R$" + f3.Salario);
        }

    }
}
