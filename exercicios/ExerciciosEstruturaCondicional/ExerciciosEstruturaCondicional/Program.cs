using System.Globalization;

namespace ExerciciosEstruturaCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio 1
            /*
            Console.Write("Digite um numero inteiro: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
            */
            #endregion

            #region Exercicio 2
            /*
            Console.Write("Digite um numero inteiro: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                Console.WriteLine("POSITIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }
            */
            #endregion

            #region Exercicio 3
            /*
            Console.Write("Digite um numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite outro numero: ");
            int b = int.Parse(Console.ReadLine());

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("MULTIPLOS!");
            }
            else
            {
                Console.WriteLine("NÃO SÃO MULTIPLOS!");
            }
            */
            #endregion

            #region Exercicio 4
            /*
            Console.Write("O jogo comecou que horas: ");
            int inicio = int.Parse(Console.ReadLine());
            Console.Write("O jogo terminou que horas: ");
            int fim = int.Parse(Console.ReadLine());

            if (inicio > fim)
            {
                int total = (24 - inicio) + fim;
                Console.WriteLine($"O JOGO DUROU {total} HORA(S)");
            }
            else if (inicio == fim)
            {
                Console.WriteLine("O JOGO DUROU 24 HORAS(S)");
            }
            else if (fim > inicio)
            {
                int total = fim - inicio;
                Console.WriteLine($"O JOGO DUROU {total} HORA(S)");
            }
            */
            #endregion

            #region Exercicio 5
            /*
            Console.Write("Digite o código do item: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantiade de items: ");
            int qnt = int.Parse(Console.ReadLine());

            double valorTotal = 0.0;

            if (codigo == 1)
            {
                valorTotal = 4.00 * qnt;
                Console.WriteLine("Total: " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 2)
            {
                valorTotal = 4.50 * qnt;
                Console.WriteLine("Total: " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 3)
            {
                valorTotal = 5.00 * qnt;
                Console.WriteLine("Total: " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 4)
            {
                valorTotal = 2.00 * qnt;
                Console.WriteLine("Total: " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 5)
            {
                valorTotal = 1.50 * qnt;
                Console.WriteLine("Total: " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("VALOR INVÁLIDO");
            }
            */
            #endregion

            #region Exercicio 6
            /*
            Console.Write("Digite um valor: ");
            double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (n >= 0 && n <= 25)
            {
                Console.WriteLine("Intervalo [0, 25]");
            }
            else if (n > 25 && n <= 50)
            {
                Console.WriteLine("Intervalo [25, 50]");
            }
            else if (n > 50 && n <= 75)
            {
                Console.WriteLine("Intervalo [50, 75]");
            }
            else if (n > 75 && n <= 100)
            {
                Console.WriteLine("Intervalo [75, 100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
            */
            #endregion

            #region Exercicio 7
            /*
            Console.Write("Digite um valor X: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite um valor Y: ");
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            */
            #endregion

            #region Exercicio 8
            Console.WriteLine("Digite seu salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;

            if (salario > 0 && salario <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (salario > 2000.00 && salario <= 3000.00)
            {
                imposto = salario * 0.08;
                Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (salario > 3000.00 && salario <= 4500.00)
            {
                imposto = salario * 0.18;
                Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                imposto = salario * 0.28;
                Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            #endregion
        }
    }
}