using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessadorBoletos_Problem
{
    public class ProcessadorDeBoletos
    {
        public void Processa(List<Boleto> boletos, Fatura fatura)
        {
            double total = 0;

            foreach (Boleto boleto in boletos)
            {
                Pagamento pagamento = new Pagamento(boleto.Valor, MeioDePagamento.BOLETO);
                fatura.Pagamentos.Add(pagamento);

                total += boleto.Valor;
            }

            // Marcar como pago deveria ser responsabilidade da Fatura
            if (total >= fatura.Valor)
            {
                fatura.Pago = true;
            }
        }
    }
}
