using System.Globalization;

namespace ExerciciosSequenciaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio 1
            /*
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preco de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha): ");
            string[] lista = Console.ReadLine().Split(' ');

            string nome1 = lista[0] ;
            int quartos1 = int.Parse(lista[1]);
            double preco1 = double.Parse(lista[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome1);
            Console.WriteLine(quartos1);
            Console.WriteLine(preco1.ToString("F2", CultureInfo.InvariantCulture));
            */
            #endregion

            #region Exercicio 2
            /*
            Console.WriteLine("Digite o primeiro valor: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            Console.WriteLine("SOMA = " + soma);
            */
            #endregion

            #region Exercicio 3
            /*
            Console.WriteLine("Digite o valor do raio de um circulo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = double.Pi * Math.Pow(raio, 2);

            Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));
            */
            #endregion

            #region Exercicio 4
            /*
            Console.WriteLine("Digite 4 números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());

            int diferenca = (n1 * n2 - n3 * n4);

            Console.WriteLine("DIFERENCA = " + diferenca);
            */
            #endregion

            #region Exercicio 5
            /*
            Console.WriteLine("Digite seu numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor que recebe por hora: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horas * valor;

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
            */
            #endregion

            #region Exercicio 6
            /*
            Console.WriteLine("Digite o código da peça: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o númerom de peças: ");
            int qnt = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de cada peça: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            Console.WriteLine("Digite o código da peça 2: ");
            int codigo2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o númerom de peças: ");
            int qnt2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de cada peça: ");
            double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorP1 = qnt * valor;
            double valorP2 = qnt2 * valor2;

            double valorTotal = valorP1 + valorP2;

            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
            */
            #endregion

            #region Exercicio 7
            Console.WriteLine("Digite três valores: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaTriangulo = (c * a) / 2;
            double areaCirculo = double.Pi * Math.Pow(c, 2);
            double areaTrapezio = (a + b) * c / 2;
            double areaQuadrado = Math.Pow(b, 2);
            double areaRetangulo = a * b;

            Console.WriteLine("TRIANGULO = " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO = " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO = " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO = " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO = " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
            #endregion
        }
    }
}