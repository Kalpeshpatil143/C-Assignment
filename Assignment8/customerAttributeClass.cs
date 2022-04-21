using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CustomAttribute
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EName { get; set; }
        public double EmpSalary { get; set; }

        public Employee(int EmpId, string EmpName, double EmpSalary)
        {
            this.EmpId = EmpId;
            this.EName = EName;
            this.EmpSalary = EmpSalary;
        }
        public void empDetails()
        {
            Console.WriteLine("Employee Id :" + EmpId);
            Console.WriteLine("Employee name :" + EName);
            Console.WriteLine("Employee Salary :" + EmpSalary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(5, "kalpesh", 456000);

            Assembly executing = Assembly.GetExecutingAssembly();
            Type[] types = executing.GetTypes();
            emp.empDetails();
            foreach (var item in types)
            {
                Console.WriteLine(item.Name);
                MethodInfo[] mi = item.GetMethods();



                foreach (var method in mi)
                {
                    Console.WriteLine(method.Name);



                }
            }
            Console.ReadLine();
        }
    }
}