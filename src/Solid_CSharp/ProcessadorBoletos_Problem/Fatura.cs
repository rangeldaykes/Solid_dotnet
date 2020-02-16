using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessadorBoletos_Problem
{
    public class Fatura
    {
        public string Cliente { get; private set; }
        public double Valor { get; set; }
        public List<Pagamento> Pagamentos { get; private set; }
        public bool Pago { get; set; }

        public Fatura(string cliente, double valor)
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this.Pagamentos = new List<Pagamento>();
            this.Pago = false;
        }
    }
}
