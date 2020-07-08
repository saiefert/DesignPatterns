using DesignPatterns.Strategy;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Orcamento reforma = new Orcamento(500.0);

            Imposto novoImposto = new ICMS();
            Console.WriteLine(novoImposto.Calcula(reforma));
        }
    }
}
