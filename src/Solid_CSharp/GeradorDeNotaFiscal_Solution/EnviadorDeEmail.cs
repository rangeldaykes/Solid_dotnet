using System;

namespace GeradorDeNotaFiscal_Solution
{
    public class EnviadorDeEmail : IAcaoAposGerarNota
    {        
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Enviando email");
        }
    }
}
