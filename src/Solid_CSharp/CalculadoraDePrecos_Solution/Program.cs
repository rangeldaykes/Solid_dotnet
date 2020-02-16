using System;

namespace CalculadoraDePrecos_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Compra compra = new Compra { Valor = 500, Cidade = "sao paulo" };
            CalculadoraDePrecos calc = new CalculadoraDePrecos(
                new TabelaDePrecoPadrao(),
                //new Frete());
                new Transportadora());

            double resultado = calc.Calcula(compra);

            Console.WriteLine("O preço de compra é : " + resultado);
            Console.ReadLine();
        }
    }
}
