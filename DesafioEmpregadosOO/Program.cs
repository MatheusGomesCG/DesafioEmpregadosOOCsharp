using System;
using System.Globalization;
using System.Text;
using System.Xml.Linq;

namespace DesafioEmpregadosOO.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do departamento: ");
            string nameDepartament = Console.ReadLine();

            Console.Write("Dia do pagamento: ");
            int payDay = int.Parse(Console.ReadLine());

            Console.Write("Email: ");
            string emailDepartament = Console.ReadLine();

            Console.Write("Telefone: ");
            string phoneNumberDepartament = Console.ReadLine();

            Department dep = new Department(nameDepartament, payDay, new Adress(emailDepartament, phoneNumberDepartament));

            Console.Write("Quantos funcionários tem o departamento? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do funcionário {i}:");
                Console.Write("Nome: ");
                string nameEmployee = Console.ReadLine();

                Console.Write("Salário: ");
                double salaryEmployee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                dep.AddEmployee(new Employee(nameEmployee, salaryEmployee));
            }

            Console.WriteLine();
            ShowReport(dep);
        }

        private static void ShowReport(Department dept)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("FOLHA DE PAGAMENTO: ");
            sb.AppendLine($"Departamento {dept.Name} = R$ {dept.Payroll().ToString("F2", CultureInfo.InvariantCulture)}");
            sb.AppendLine($"Pagamento realizado no dia {dept.PayDay}");
            sb.AppendLine("Funcionários:");
            foreach (Employee obj in dept.EmployeeDepartament)
            {
                sb.AppendLine(obj.Name);
            }
            sb.AppendLine($"Para dúvidas favor entrar em contato: {dept.AdressDepartament.Email}");

            Console.WriteLine(sb.ToString());
        }
    }
}