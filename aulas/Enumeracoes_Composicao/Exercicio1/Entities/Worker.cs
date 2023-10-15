using Exercicio1.Entities.Enums;

namespace Exercicio1.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> ContractList { get; set; }

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
            ContractList = new List<HourContract>();
        }

        public void AddContract(HourContract contract)
        { 
            ContractList.Add(contract);
        }

        public void RemoveContract(HourContract contract)   
        {
            ContractList.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double totalIncome = 0;

            foreach (var contract in ContractList)
            {
                if (contract.Date.Month == month && contract.Date.Year == year)
                {
                    totalIncome += contract.TotalValue();
                }
            }

            return totalIncome;
        }
    }
}
