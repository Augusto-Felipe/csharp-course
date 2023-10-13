namespace Listas.Entities
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int iD, string name, double salary)
        {
            ID = iD;
            Name = name;
            Salary = salary;
        }
    }
}
