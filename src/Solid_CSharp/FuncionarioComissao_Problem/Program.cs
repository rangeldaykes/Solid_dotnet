using System;

namespace FuncionarioComissao_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            // não faz sentido para dev ter o comportamento
            // getComissao()

            Console.WriteLine("Hello World!");
        }
    }

    public abstract class Funcionario
    {
        private string _nome;

        public string getNome()
        {
            return _nome;
        }

        public void setNome(string nome)
        {
            _nome = nome;
        }

        public abstract double getSalario();
        public abstract double getComissao();
    }

    public class Vendedor : Funcionario
    {
        private double _salario;
        private int _totalVendas;

        public Vendedor(double salario, int totalVendas)
        {
            _salario = salario;
            _totalVendas = totalVendas;
        }

        public override double getSalario()
        {
            return _salario + getComissao();
        }

        public override double getComissao()
        {
            return _totalVendas * 0.2;
        }
    }

    public class Desenvolvedor : Funcionario
    {
        private double _salario;

        public Desenvolvedor(double salario)
        {
            _salario = salario;
        }

        public override double getSalario()
        {
            return _salario;
        }

        public override double getComissao()
        {
            return 0d;
        }
    }
}
