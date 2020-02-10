using System;

namespace GeradorDeNotaFiscal_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            EnviadorDeEmail enviadorDeEmail = new EnviadorDeEmail();
            NotaFiscalDao notaFiscalDao = new NotaFiscalDao();
            GeradorDeNotaFiscal geradorDeNotaFiscal = new GeradorDeNotaFiscal(enviadorDeEmail, notaFiscalDao);
            Fatura fatura = new Fatura(200, "José LeLé");

            geradorDeNotaFiscal.Gera(fatura);

            Console.ReadLine();
        }
    }
}
