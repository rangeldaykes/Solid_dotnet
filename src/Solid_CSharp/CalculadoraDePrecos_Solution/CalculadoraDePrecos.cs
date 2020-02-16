using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDePrecos_Solution
{
    public class CalculadoraDePrecos
    {
        private readonly ITabelaDePreco _tabela;
        private readonly IServicoDeEntrega _entrega;

        public CalculadoraDePrecos(ITabelaDePreco tabela, IServicoDeEntrega entrega)
        {
            _tabela = tabela;
            _entrega = entrega;
        }

        public double Calcula(Compra produto)
        {
            double desconto = _tabela.DescontoPara(produto.Valor);
            double frete = _entrega.Para(produto.Cidade);

            return produto.Valor * (1 - desconto) + frete;
        }
    }
}
