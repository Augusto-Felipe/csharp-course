namespace Listas.Entities
{
    internal class Company
    {
        public List<Employee> EmployeeList { get; set; }

        public Company()
        {
            EmployeeList = new List<Employee>();
        }

        public void IncreaseSalary(int id, double percentage)
        {

            foreach (var employee in EmployeeList)
            {
                if (id == employee.ID)
                {
                    employee.Salary += (employee.Salary * percentage) / 100;
                }
            }
        }
    }
}
