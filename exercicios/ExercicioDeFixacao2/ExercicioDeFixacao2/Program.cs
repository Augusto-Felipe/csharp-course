using ExercicioDeFixacao2.Entities;
using System.Globalization;

namespace ExercicioDeFixacao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio 1
            
            Conta c1;

            try
            {
                Console.Write("Entre o número da conta: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Entre o titular da conta: ");
                string nome = Console.ReadLine();
                Console.Write("Havera deposito inicial (s/n)? ");
                char r = char.Parse(Console.ReadLine());

                if (r == 's')
                {
                    Console.WriteLine();
                    Console.Write("Entre com o valor do deposito inicial: ");
                    double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    c1 = new Conta(numero, nome, valor);

                    Console.WriteLine();
                    Console.WriteLine("Dados da conta:");
                    Console.WriteLine(c1);

                    Console.WriteLine();
                    Console.Write("Entre um valor para deposito: ");
                    c1.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                    Console.WriteLine("Dados da conta atualizado:");
                    Console.WriteLine(c1);

                    Console.WriteLine();
                    Console.Write("Entre um valor para sacar: ");
                    c1.Sacar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                    Console.WriteLine();
                    Console.WriteLine("Dados da conta atualizado:");
                    Console.WriteLine(c1);
                }
                else if (r == 'n')
                {
                    c1 = new Conta(numero, nome);

                    Console.WriteLine();
                    Console.WriteLine("Dados da conta:");
                    Console.WriteLine(c1);

                    Console.WriteLine();
                    Console.Write("Entre um valor para deposito: ");
                    c1.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                    Console.WriteLine();
                    Console.WriteLine("Dados da conta atualizado:");
                    Console.WriteLine(c1);

                    Console.WriteLine();
                    Console.Write("Entre um valor para sacar: ");
                    c1.Sacar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                    Console.WriteLine();
                    Console.WriteLine("Dados da conta atualizado:");
                    Console.WriteLine(c1);
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("ERRO = " + ex.Message);
            }
            
            #endregion

        }
    }
}