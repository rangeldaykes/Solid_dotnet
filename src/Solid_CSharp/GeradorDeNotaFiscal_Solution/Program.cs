using System;
using System.Collections;
using System.Collections.Generic;

namespace GeradorDeNotaFiscal_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            EnviadorDeEmail enviadorDeEmail = new EnviadorDeEmail();
            NotaFiscalDao notaFiscalDao = new NotaFiscalDao();

            var acoes = new List<IAcaoAposGerarNota>();
            acoes.Add(new EnviadorDeEmail());
            acoes.Add(new NotaFiscalDao());
            acoes.Add(new Sap());

            var geradorDeNotaFiscal = new GeradorDeNotaFiscal(acoes);
            Fatura fatura = new Fatura(200, "José LeLé");

            geradorDeNotaFiscal.Gera(fatura);

            Console.ReadLine();
        }
    }
}
