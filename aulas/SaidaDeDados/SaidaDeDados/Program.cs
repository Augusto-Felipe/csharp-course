using System.Globalization;

namespace SaidaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Saida de dados
            // WRITELINE -> IMPRIMI UM TEXTO NO CONSOLE E QUEBRA UMA LINHA
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Boa tarde!");

            //WRITE -> IMPRIMIT UM TEXTO NO CONSOLE E NÃO QUEBRA UMA LINHA
            Console.Write("TESTE 1");
            Console.Write("TESTE 2");
            #endregion

            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();

            #region Imprimindo Variáveis
            char genero = 'M';
            int idade = 29;
            double saldo = 10.354583;
            string nome = "Maria";

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            #endregion

            #region Placeholders,Concatenação e Interpolação
            Console.WriteLine("{0} tem {1} anos", nome, idade);
            Console.WriteLine($"{nome} tem {idade} anos");
            Console.WriteLine(nome + " tem " + idade + " anos");
            #endregion
        }
    }
}