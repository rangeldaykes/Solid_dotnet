using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDePrecos_Problem
{
    public class Frete
    {
        public double Para(string cidade)
        {

            if ("SAO PAULO".Equals(cidade.ToUpper()))
            {
                return 15;
            }
            return 30;
        }
    }
}
