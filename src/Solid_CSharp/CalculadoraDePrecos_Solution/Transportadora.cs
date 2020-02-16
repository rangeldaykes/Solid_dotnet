using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDePrecos_Solution
{
    public class Transportadora : IServicoDeEntrega
    {
        public double Para(string cidade)
        {
            return 5;
        }
    }
}
