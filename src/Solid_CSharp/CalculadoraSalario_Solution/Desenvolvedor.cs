using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraSalario_Solution
{
    public class Desenvolvedor : Cargo
    {
        public Desenvolvedor(IRegraDeCalculo regra) : base(regra)
        {
        }
    }
}
