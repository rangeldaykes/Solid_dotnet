using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessadorBoletos_Solution
{
    public class ProcessadorDeBoletos
    {
        public void Processa(IList<Boleto> boletos, Fatura fatura)
        {
            foreach (Boleto boleto in boletos)
            {
                Pagamento pagamento = new Pagamento(boleto.Valor, MeioDePagamento.BOLETO);

                // Agora apenas adicionamos o pagamento
                fatura.AdicionaPagamento(pagamento);
            }
        }
    }
}
