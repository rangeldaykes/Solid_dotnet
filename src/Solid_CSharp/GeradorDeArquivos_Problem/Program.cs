using System;
using System.Collections.Generic;

namespace GeradorDeArquivos_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gerando Arquivos!!!");

            ArquivoWord arquivoWord = new ArquivoWord();
            ArquivoPdf arquivoPdf = new ArquivoPdf();

            IList<Arquivo> listArquivo = new List<Arquivo>();
            listArquivo.Add(arquivoWord);
            listArquivo.Add(arquivoPdf);

            GeradorDeArquivos geradorDeArquivos = new GeradorDeArquivos();
            geradorDeArquivos.GerarArquivos(listArquivo);
            Console.ReadLine();
        }
    }

    public class Arquivo
    {
    }

    public class ArquivoWord : Arquivo
    {
        public void GerarDocX()
        {
            // codigo para geracao do arquivo
            Console.WriteLine("Gerou arquivo docx");
        }
    }

    public class ArquivoPdf : Arquivo
    {
        public void GerarPdf()
        {
            // codigo para geracao do arquivo
            Console.WriteLine("Gerou arquivo pdf");
        }
    }

    public class GeradorDeArquivos
    {
        public void GerarArquivos(IList<Arquivo> arquivos)
        {
            foreach (var arquivo in arquivos)
            {
                if (arquivo is ArquivoWord)
                    ((ArquivoWord)arquivo).GerarDocX();
                else if (arquivo is ArquivoPdf)
                    ((ArquivoPdf)arquivo).GerarPdf();
            }
        }
    }
}