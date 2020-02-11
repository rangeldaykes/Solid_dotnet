using System;
using System.Collections.Generic;
using System.Text;

namespace GeradorDeNotaFiscal_Solution
{
    public interface IAcaoAposGerarNota
    {
        void Executa(NotaFiscal nf);
    }
}
