using System;
using System.Collections.Generic;

namespace GerenciadorDeContas_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando Contas");

            List<ContaCorrenteComum> listaDeContasComum = new List<ContaCorrenteComum>();

            var cc1 = new ContaCorrenteComum();
            cc1.Deposita(100);
            listaDeContasComum.Add(cc1);

            foreach (ContaCorrenteComum conta in listaDeContasComum)
            {
                conta.Rende();
                Console.WriteLine("Novo Saldo:");
                Console.WriteLine(conta.GetSaldo());
            }

            List<ContaSalario> listaDeContasSalario = new List<ContaSalario>();
            var cs1 = new ContaSalario();
            cs1.Deposita(200);            
            listaDeContasSalario.Add(cs1);

            foreach (ContaSalario conta in listaDeContasSalario)
            {
                Console.WriteLine("Novo Saldo:");
                Console.WriteLine(conta.GetSaldo());
            }

            Console.ReadLine();
        }
    }

    public class GerenciadorDeContas
    {
        private double saldo;

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public void Saca(double valor)
        {
            if (valor <= this.saldo)
            {
                this.saldo -= valor;
            }
            else
            {
                throw new Exception("Saldo insuficiente.");
            }
        }

        public double GetSaldo()
        {
            return saldo;
        }

        public void Rende(double taxa)
        {
            this.saldo = this.saldo + (this.saldo * taxa);
        }
    }

    public class ContaCorrenteComum
    {
        private GerenciadorDeContas gerenciador;

        public ContaCorrenteComum()
        {
            this.gerenciador = new GerenciadorDeContas();
        }

        public void Deposita(double valor)
        {
            this.gerenciador.Deposita(valor);
        }

        public void Saca(double valor)
        {
            this.gerenciador.Saca(valor);
        }

        public double GetSaldo()
        {
            return this.gerenciador.GetSaldo();
        }

        public void Rende()
        {
            this.gerenciador.Rende(0.02);
        }

        public override string ToString()
        {
            return "Saldo conta corrente-> " + this.GetSaldo();
        }
    }

    public class ContaSalario
    {
        private GerenciadorDeContas gerenciador;

        public ContaSalario()
        {
            this.gerenciador = new GerenciadorDeContas();
        }

        public void Deposita(double valor)
        {
            this.gerenciador.Deposita(valor);
        }

        public void Saca(double valor)
        {
            this.gerenciador.Saca(valor);
        }

        public double GetSaldo()
        {
            return this.gerenciador.GetSaldo();
        }
        
        public override string ToString()
        {
            return "Saldo conta salario-> " + this.GetSaldo();
        }
    }
}
