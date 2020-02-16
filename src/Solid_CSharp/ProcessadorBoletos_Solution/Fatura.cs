using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessadorBoletos_Solution
{
    public class Fatura
    {
        public string Cliente { get; private set; }
        public double Valor { get; set; }
        private List<Pagamento> pagamentos;
        public bool Pago { get; private set; }

        public Fatura(string cliente, double valor)
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this.pagamentos = new List<Pagamento>();
            this.Pago = false;
        }

        public void AdicionaPagamento(Pagamento pagamento)
        {
            pagamentos.Add(pagamento);

            if (valorTotalDosPagamentos() >= Valor)
                Pago = true;
        }

        private double valorTotalDosPagamentos()
        {
            double total = 0;

            foreach (var pag in pagamentos)
            {
                total += pag.Valor;
            }

            return total;
        }
    }
}
