
using System.Collections;
using System.Collections.Generic;

namespace GeradorDeNotaFiscal_Solution
{
    public class GeradorDeNotaFiscal
    {
        private IList<IAcaoAposGerarNota> _acoes;

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota>  acoes)
        {
            _acoes = acoes;
        }

        public NotaFiscal Gera(Fatura fatura)
        {

            double valor = fatura.ValorMensal;

            NotaFiscal nf = new NotaFiscal(valor, ImpostoSimplesSobreO(valor));

            // agora apenas chamamos quem se "inscreveu" para axecutar alguma ação após Gerar
            foreach (var acao in _acoes)
            {
                acao.Executa(nf);
            }

            return nf;
        }

        private double ImpostoSimplesSobreO(double valor)
        {
            return valor * 0.06;
        }
    }
}
