using System.Globalization;

namespace ExerciciosEstruturaFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio 1
            /*
            Console.Write("Digite um valor inteiro: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            */
            #endregion

            #region Exercicio 2
            /*
            Console.Write("Digite um valor inteiro: ");
            int qnt = int.Parse(Console.ReadLine());

            int dentro = 0;
            int fora = 0;

            for (int i = 0; i < qnt; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (n >= 10 && n <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }

            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
            */
            #endregion

            #region Exercicio 3
            /*
            Console.Write("Digite um valor inteiro: ");
            int qnt = int.Parse(Console.ReadLine());

            List<double> listaNotas = new List<double>();

            for (int i = 0; i < qnt; i++)
            {
                double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
            */
            #endregion

            #region Exercicio 4
            /*
            Console.Write("Digite um numero inteiro: ");
            int qnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < qnt; i++)
            {
                double n1 = int.Parse(Console.ReadLine());
                double n2 = int.Parse(Console.ReadLine());

                if (n2 == 0)
                {
                    Console.WriteLine("Divisão impossível!");
                }
                else
                {
                    double divisao = n1 / n2;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
            */
            #endregion

            #region Exercicio 5
            /*
            Console.Write("Digite um valor inteiro: ");
            int n = int.Parse(Console.ReadLine());

            int fatorial = 1;

            for (int i = 1; i <= n; i++)
            {
                fatorial = fatorial * i;
            }

            Console.WriteLine("FATORIAL = " + fatorial);
            */
            #endregion

            #region Exercicio 6
            /*
            Console.Write("Digite um numero inteiro: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */
            #endregion

            #region Exercicio 7
            Console.Write("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int primeiro = i;
                double segundo = Math.Pow(i, 2);
                double terceiro = Math.Pow(i, 3);
                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            }
            #endregion
        }
    }
}