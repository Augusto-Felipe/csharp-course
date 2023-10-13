using Listas.Entities;
using System.Globalization;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Aula
            /*
            // Declarando e instanciando nova lista vazia
            List<string> lista = new List<string>();

            // Adicionando items no final da lista
            lista.Add("Maria");
            lista.Add("Alex");
            lista.Add("Anna");

            // Adicionando items indicando a posição
            lista.Insert(2, "Marco");

            // Iterando lista
            foreach (var name in lista)
            {
                Console.WriteLine(name);
            }

            // Quantiadde de items na lista
            Console.WriteLine("Quantidade de items na lista: " + lista.Count);

            // Procurar por item na lista => Expressão LAMBDA
            string s2 = lista.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s2);

            string s3 = lista.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s3);

            string s4 = lista.Find(x => x[0] == 'M');
            Console.WriteLine("First 'M': " + s4);

            string s5 = lista.FindLast(x => x[0] == 'M');
            Console.WriteLine("Last 'M': " + s5);

            int s6 = lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First index 'A': " + s6);

            List<string> lista2 = lista.FindAll(x => x.Length == 5);

            foreach (var name in lista2)
            {
                Console.WriteLine(name);
            }
            */
            #endregion

            #region Exercicio de Fixação

            Company company = new Company();

            Console.Write("How many employess will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i+1}: ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                company.EmployeeList.Add(new Employee(id, name, salary));

                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idIncrease = int.Parse(Console.ReadLine());

            Console.Write("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            company.IncreaseSalary(idIncrease, percentage);

            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");
            foreach (var employee in company.EmployeeList)
            {
                Console.WriteLine($"{employee.ID}, {employee.Name}, {employee.Salary.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            #endregion
        }
    }
}