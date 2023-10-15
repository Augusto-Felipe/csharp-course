using Exercicio1.Entities;
using Exercicio1.Entities.Enums;
using System.Globalization;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string departmentString = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(departmentString);
            
            Worker worker = new Worker(name, level, salary, department);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i+1} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                
                string input2 = Console.ReadLine();

                DateTime date;

                if (DateTime.TryParseExact(input2, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    
                }
                else
                {
                    Console.WriteLine("Data inválida. Certifique-se de seguir o formato DD/MM/YYYY.");
                }

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());

                worker.AddContract(new HourContract(date, valuePerHour, duration));

                Console.WriteLine();
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            Console.Write("Date (MM/YYYY): ");

            string input = Console.ReadLine();
            string[] parts = input.Split('/');

            int month;
            int year;

            if (parts.Length == 2 && int.TryParse(parts[0], out month) && int.TryParse(parts[1], out year))
            {
                Console.WriteLine("Name: " + worker.Name);
                Console.WriteLine("Department: " + worker.Department.Name);
                Console.WriteLine($"Income for {month}/{year}: " + worker.Income(year, month));
            }
            else
            {
                Console.WriteLine("Entrada inválida. Certifique-se de seguir o formato MM/YYYY.");
            }
        }
    }
}