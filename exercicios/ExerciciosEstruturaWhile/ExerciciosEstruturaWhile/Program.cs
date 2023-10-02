namespace ExerciciosEstruturaWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio 1
            /*
            Console.Write("Digite a senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida, Tente novamente!");
                Console.Write("Digite sua senha:");

                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Senha correta!");
            */
            #endregion

            #region Exercicio 2
            /*
            Console.Write("Digite a coordernada X: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Digite a coordernada Y: ");
            double y = double.Parse(Console.ReadLine());

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Quadrante 1");
                }
                else if (y > 0 && x < 0)
                {
                    Console.WriteLine("Quadrante 2");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Quadrante 3");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Quadrante 4");
                }

                Console.Write("Digite a coordernada X: ");
                x = double.Parse(Console.ReadLine());

                Console.Write("Digite a coordernada Y: ");
                y = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Programa encerrado!");
            */
            #endregion

            #region Exercicio 3

            Console.WriteLine("Bem vindo a nossa pesquisa!");
            Console.WriteLine("Por gentileza, escolha uma das opções abaixo:");
            Console.WriteLine("1 - Alcool");
            Console.WriteLine("2 - Gasolina");
            Console.WriteLine("3 - Diesel");
            Console.WriteLine("4 - SAIR");

            int option = int.Parse(Console.ReadLine());

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (option != 4)
            {
                if (option == 1)
                {
                    alcool++;
                }
                else if (option == 2)
                {
                    gasolina++;
                }
                else if (option == 3)
                {
                    diesel++;
                }

                option = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
            #endregion
        }
    }
}