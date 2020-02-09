using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraSalario_Solution
{
    public interface IRegraDeCalculo
    {
        double Calcula(Funcionario funcionario);
    }
}
