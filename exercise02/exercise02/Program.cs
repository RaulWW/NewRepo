using System;
using System.Globalization;

namespace exercise02
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria conta1;
            
            Console.WriteLine("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Titular da conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá deposito inicial? S/N: ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S')
            {
                Console.WriteLine("Entre com o valor de deposito inicial: $");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta1 = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta1 = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("");
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(conta1);

            Console.WriteLine("");
            Console.WriteLine("Entre um Valor para Depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta1.Deposito(quantia);
            
            Console.WriteLine("Dados da Conta Atualizados: ");
            Console.WriteLine(conta1);
            
            Console.WriteLine("");
            Console.WriteLine("Entre um Valor para Saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta1.Saque(quantia);
            
            Console.WriteLine("Dados da Conta Atualizados: ");
            Console.WriteLine(conta1);


        }
    }
}

