using System;
using System.Collections.Generic;
using System.Text;

namespace GeradorDeNotaFiscal_Solution
{
    public class Sap : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Enviando nota SAP");
        }
    }
}
