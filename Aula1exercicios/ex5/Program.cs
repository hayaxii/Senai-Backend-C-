using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {

            string nomeVendedor;
            double salarioFixo, totalVenda, totalCalculo;

            Console.WriteLine("Digite seu nome");

            nomeVendedor = Console.ReadLine();
            
            Console.WriteLine("Digite seu salario");

            salarioFixo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite total de vendas");

            totalVenda = double.Parse(Console.ReadLine());

            totalCalculo = salarioFixo + (totalVenda *0.10);

            Console.WriteLine("Retorno" + totalCalculo);
        }
    }
}
