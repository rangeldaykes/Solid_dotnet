using System;
using System.Collections.Generic;

namespace GerenciadorDeContas_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando Contas");

            List<ContaCorrenteComum> listaDeContas = new List<ContaCorrenteComum>();
            var cc1 = new ContaCorrenteComum();
            cc1.Deposita(100);
            listaDeContas.Add(cc1);

            var cs1 = new ContaSalario();
            cs1.Deposita(200);
            listaDeContas.Add(cs1);

            foreach (ContaCorrenteComum conta in listaDeContas)
            {
                conta.Rende();
                Console.WriteLine("Novo Saldo:");
                Console.WriteLine(conta.GetSaldo());
            }

            Console.ReadLine();
        }
    }

    public class ContaCorrenteComum
    {
        protected double saldo;

        public ContaCorrenteComum()
        {
            this.saldo = 0;
        }

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

        public virtual void Rende()
        {
            this.saldo *= 0.02;
        }
    }

    public class ContaSalario : ContaCorrenteComum
    {
        public override void Rende()
        {
            throw new Exception("Essa conta não possui rendimento");
        }
    }
}
