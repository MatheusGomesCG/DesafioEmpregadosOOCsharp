using System;
using System.Globalization;
using System.Text;

namespace DesafioEmpregadosOO.Entities
{
    class Department
    {

        public string Name { get; private set; }
        public int PayDay { get; private set; }
        public Adress AdressDepartament { get; private set; }
        public List<Employee> EmployeeDepartament { get; private set; } = new List<Employee>();

        public Department()
        {
        }

        public Department(string name, int payDay, Adress adressDepartament)
        {
            Name = name;
            PayDay = payDay;
            AdressDepartament = adressDepartament;
        }

        public void AddEmployee(Employee employee)
        {
            EmployeeDepartament.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            EmployeeDepartament.Remove(employee);
        }

        public double Payroll()
        {
            double sum = 0;
            foreach (Employee obj in EmployeeDepartament)
            {
                sum += obj.Salary;
            }
            return sum;
        }
    }
}
