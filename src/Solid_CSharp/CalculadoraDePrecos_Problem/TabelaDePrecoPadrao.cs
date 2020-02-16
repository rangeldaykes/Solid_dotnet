﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDePrecos_Problem
{
    public class TabelaDePrecoPadrao
    {
        public double DescontoPara(double valor)
        {
            if (valor > 5000) return 0.03;
            if (valor > 1000) return 0.05;
            return 0;
        }
    }
}
