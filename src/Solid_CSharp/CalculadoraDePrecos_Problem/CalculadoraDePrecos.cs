using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDePrecos_Problem
{
    public class CalculadoraDePrecos
    {
        public double Calcula(Compra produto)
        {
            // Para modificar a tabela ou o frete tem que mudar este código
            TabelaDePrecoPadrao tabela = new TabelaDePrecoPadrao();
            Frete correios = new Frete();

            double desconto = tabela.DescontoPara(produto.Valor);
            double frete = correios.Para(produto.Cidade);

            return produto.Valor * (1 - desconto) + frete;
        }
    }
}
