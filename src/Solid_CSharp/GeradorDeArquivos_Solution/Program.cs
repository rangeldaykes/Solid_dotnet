using System;
using System.Collections.Generic;

namespace GeradorDeArquivos_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gerando Arquivos!!!");

            ArquivoWord arquivoWord = new ArquivoWord();
            ArquivoPdf arquivoPdf = new ArquivoPdf();
            ArquivoTxt arquivoTxt = new ArquivoTxt();

            IList<Arquivo> listArquivo = new List<Arquivo>
            {
                arquivoWord,
                arquivoPdf,
                arquivoTxt
            };

            GeradorDeArquivos geradorDeArquivos = new GeradorDeArquivos();
            geradorDeArquivos.GerarArquivos(listArquivo);
            Console.ReadLine();
        }
    }

    public abstract class Arquivo
    {
        public abstract void Gerar();
    }

    public class ArquivoWord : Arquivo
    {
        public override void Gerar()
        {
            // codigo para geracao do arquivo
            Console.WriteLine("Gerou arquivo docx");
        }
    }

    public class ArquivoPdf : Arquivo
    {
        public override void Gerar()
        {
            // codigo para geracao do arquivo
            Console.WriteLine("Gerou arquivo pdf");
        }
    }

    public class ArquivoTxt : Arquivo
    {
        public override void Gerar()
        {
            // codigo para geracao do arquivo
            Console.WriteLine("Gerou arquivo txt");
        }
    }

    public class GeradorDeArquivos
    {
        public void GerarArquivos(IList<Arquivo> arquivos)
        {
            foreach (var arquivo in arquivos)
                arquivo.Gerar();
        }
    }
}
