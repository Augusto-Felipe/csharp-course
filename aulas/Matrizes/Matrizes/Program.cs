namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Aula
            /*
            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length);
            Console.WriteLine(mat.Rank);
            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));
            */
            #endregion


            #region Exercicio 1
            Console.Write("Digite um numero inteiro: ");
            int n = int.Parse(Console.ReadLine());

            double[,] mat = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Digite o valor da posição: [{i}, {j}]: ");
                    mat[i, j] = int.Parse(Console.ReadLine()); 
                }
            }

            int sumNegativos = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine(mat[i,j]);
                    }

                    if (mat[i, j] < 0)
                    {
                        sumNegativos += 1;
                    }
                }
            }
            Console.WriteLine("Numeros negativos = " + sumNegativos);
            #endregion

        }
    }
}