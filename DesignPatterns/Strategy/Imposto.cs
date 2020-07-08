using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    interface Imposto
    {
        double Calcula(Orcamento orcamento);
    }
}
