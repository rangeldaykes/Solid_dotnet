using System;

namespace FuncionarioComissao_Solution
{
    /// <summary>
    /// Refatorando o código para quebrar esses comportamentos 
    /// em duas interfaces: Comissionavel e Convencional. 
    /// Assim, o Funcionario passa a implementar a interface
    /// Convencional, fazendo com que a classe Desenvolvedor
    /// nem precise existir, já que o Desenvolvedor é um 
    /// Funcionario com regime Convencional. Da mesma forma, 
    /// a classe Vendedor passa a implementar a interface 
    /// Comissionavel, que agora terá como comportamento o 
    /// método getComissao(), que é específico desse tipo de Funcionario.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public interface IConvencional
    {
        public double getSalario();
    }

    public abstract class Funcionario : IConvencional
    {
        private string _nome;
        private double _salario;

        public string getNome()
        {
            return _nome;
        }

        public void setNome(string nome)
        {
            _nome = nome;
        }

        public virtual double getSalario()
        {
            return _salario;
        }

        public void setSalario(double salario)
        {
            _salario = salario;
        }
    }

    public interface IComissionavel
    {
        public double getComissao();
    }

    public class Vendedor : Funcionario, IComissionavel
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

        public double getComissao()
        {
            return _totalVendas * 0.2;
        }

        public override string ToString()
        {
            return $"Vendedor [salario=" + _salario + ", totalVendas=" + _totalVendas + "]";
        }
    }
}
