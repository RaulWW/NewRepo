using System;
using System.Globalization;

namespace exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.WriteLine("Nome: ");
            f.Nome = Console.ReadLine();

            Console.WriteLine("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("");
            Console.WriteLine($"Funcionário: {f}");

            Console.WriteLine("");
            Console.WriteLine("Informe a % de aumento: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(porcent);

            Console.WriteLine("");
            Console.WriteLine($"Valores atualizados: {f}");

        }
    }
}
