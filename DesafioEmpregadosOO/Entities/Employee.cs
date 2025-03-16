using System;

namespace DesafioEmpregadosOO.Entities
{
    class Employee
    {
        public string Name { get; private set; }
        public double Salary { get; private set; }

        public Employee()
        {
        }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}
