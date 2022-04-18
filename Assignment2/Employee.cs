using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Employee
    {
        private int EmpNo; 
        private string EmpName;
        private double Salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double NetSalary;
        private double GrossSalary;

        public void GetEmployeeDetails(int empNo, string empName, double salary)
        {
            this.EmpNo = empNo;
            this.EmpName = empName;
            if (salary < 5000)
            {
                this.HRA = salary * 10 / 100;
                this.TA = salary * 5 / 100;
                this.DA = salary * 15 / 100;
                this.GrossSalary = salary + HRA + TA + DA;
                CalculateSalary();
            }
            else if (salary < 10000)
            {
                this.HRA = salary * 15 / 100;
                this.TA = salary * 10 / 100;
                this.DA = salary * 20 / 100;
                this.GrossSalary = salary + HRA + TA + DA;
                CalculateSalary();
            }
            else if (salary < 15000)
            {
                this.HRA = salary * 20 / 100;
                this.TA = salary * 15 / 100;
                this.DA = salary * 25 / 100;
                this.GrossSalary = salary + HRA + TA + DA;
                CalculateSalary();
            }
            else if (salary < 20000)
            {
                this.HRA = salary * 25 / 100;
                this.TA = salary * 20 / 100;
                this.DA = salary * 30 / 100;
                this.GrossSalary = salary + HRA + TA + DA;
                CalculateSalary();
            }
            else if (salary >= 20000)
            {
                this.HRA = salary * 30 / 100;
                this.TA = salary * 25 / 100;
                this.DA = salary * 35 / 100;
                this.GrossSalary = salary + HRA + TA + DA;
                CalculateSalary();
            }
            Console.WriteLine($"Employee Name - {EmpName}");
            Console.WriteLine($"Employee No - {EmpNo}");
            Console.WriteLine();
            Console.WriteLine($"Employee Salary Calculations:");
            Console.WriteLine($"\tHRA - {HRA}");
            Console.WriteLine($"\tTA - {TA}");
            Console.WriteLine($"\tDA - {DA}");
            Console.WriteLine($"\tGrossSalary - {GrossSalary}");
            Console.WriteLine($"\tPF - {PF}");
            Console.WriteLine($"\tTDS - {TDS}");
            Console.WriteLine($"\tNetSalary - {NetSalary}");
        }
        public void CalculateSalary()
        {
            PF = GrossSalary * 10 / 100;
            TDS = GrossSalary * 18 / 100;
            NetSalary = GrossSalary - (PF + TDS);
        }
        public static void Main(String[] args)
        {
            Employee emp = new Employee();
            emp.GetEmployeeDetails(1234567, "Kalpesh", 5000);
            Console.ReadLine();

        }
    }
}
