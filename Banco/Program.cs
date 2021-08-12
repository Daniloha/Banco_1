using System;
using System.Globalization;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
        Erro:
            Console.Write("Haverá depósito inicial (s/n)? ");
            string d = Console.ReadLine();
            double saldo = 0;
            double add = 0;

            switch (d)
            {
                case "s":
                    Console.Write("Entre o valor de depósito inicial: ");
                    saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    break;

                case "n":
                    saldo = 0;
                    break;

                default:
                    Console.WriteLine("ERRO");
                    goto Erro;
            }
            Conta A = new Conta(numero, nome, saldo);

            Console.WriteLine("");
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(A);
            string c = null;

        ERRO2:

            while (c != "f")
            {
                Console.WriteLine("");
                Console.Write("Deseja realizar alguma operação (s/n)?");
                string o = Console.ReadLine();

                switch (o)
                {
                    case "s":
                        Console.WriteLine("Qual operação você deseja realizar? ");
                        Console.WriteLine("Digite 's' para saque; ");
                        Console.WriteLine("Digite 'd' para depósito; ");
                        Console.WriteLine("Digite 'e' para extrato; ");
                        Console.WriteLine("Digite 'f' para finalizar; ");
                        c = Console.ReadLine();
                        break;

                    case "n":
                        goto FIM;

                    default:
                        Console.WriteLine("ERRO");
                        goto ERRO2;
                }

                switch (c)
                {
                    case "s":
                        Console.Write("Entre um valor para saque: ");
                        add = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        A.Saque(add);
                        Console.WriteLine(A);
                        break;

                    case "d":
                        Console.Write("Entre um valor para depósito: ");
                        add = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        A.Deposito(add);
                        Console.WriteLine(A);
                        break;

                    case "e":
                        Console.WriteLine(A);
                        break;

                    case "f":
                        goto FIM;

                    default:
                        Console.WriteLine("ERRO");
                        goto ERRO2;
                }
            }
        FIM:;
        }
    }
}
