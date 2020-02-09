using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraSalario_Solution
{
    public class Dba : Cargo
    {
        public Dba(IRegraDeCalculo regra) : base(regra)
        {
        }
    }
}
