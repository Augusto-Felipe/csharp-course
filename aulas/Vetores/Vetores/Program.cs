using Vetores.Entities;

namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio 1
            /*
            double[] lista = new double[9];
            double media = 0.0;

            Console.Write("Digite a quantidade de pessoas: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite sua altura: ");
                lista[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            foreach (var altura in lista)
            {
                media += altura;
            }

            media = media / n;

            Console.WriteLine("MÉDIA = " + media.ToString("F2", CultureInfo.InvariantCulture));
            */
            #endregion

            #region Exercicio 2
            /*
            Console.Write("Digite a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());
            Product[] lista = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o nome do produto: ");
                string name = Console.ReadLine();
                Console.Write("Digite o valor do produto: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                lista[i] = new Product
                {
                    Name = name,
                    Price = price
                };
            }

            double sum = 0.0;
            foreach (var produto in lista)
            {
                sum += produto.Price;
            }

            double avg = sum / n;

            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
            */
            #endregion

            #region Exercicio de Fixação

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            Pension p = new Pension();

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Rent #{i+1}: ");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.WriteLine();

                p.Rent(name, email, roomNumber);
            }

            foreach (var room in p.Rooms)
            {
                if (room != null)
                {
                    Console.WriteLine("Busy rooms: ");
                    Console.WriteLine($"{room.Number}: {room.Name}, {room.Email}");
                }
            }
            #endregion
        }
    }
}