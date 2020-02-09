using First_SRP_Single_Responsibility;
using System;

namespace CalculadoraSalario_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var cs = new CalculadoraDeSalario();
            var funcionario = new Funcionario(new Desenvolvedor(), 2000);
            double resultado;

            resultado = cs.Calcula(funcionario);

            Console.WriteLine($"O salario de um desenvolvedor que ganha 2000 bruto é : {resultado}");

            Console.ReadLine();
        }
    }
}
