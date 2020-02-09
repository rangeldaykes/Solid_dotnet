using System;

namespace CalculadoraSalario_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var cs = new CalculadoraDeSalario();
            var funcionario = new Funcionario(
                new Desenvolvedor(                    
                    new DezOuVintePorcento()), 2000);

            double resultado;

            resultado = cs.Calcula(funcionario);

            Console.WriteLine($"O salario de um desenvolvedor que ganha 2000 bruto é : {resultado}");

            Console.ReadLine();
        }
    }
}
