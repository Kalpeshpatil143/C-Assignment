using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSal { get; set; }
        public string EmpLoc { get; set; }


    }

    internal class ArrayListSample
    {
        static void Main(string[] args)
        {
            //object initilizer or collection initilizer
            //ArrayList e = new ArrayList();//non generic

            ArrayList e = new ArrayList()
            {
                    new Employee{EmpId=1,EmpName="Kalpesh",EmpSal=25000,EmpLoc="mumbai"},
                    new Employee{EmpId=2,EmpName="Dhiraj",EmpSal=23000,EmpLoc="banglore"},
                    new Employee{EmpId=3,EmpName="kiran",EmpSal=32000,EmpLoc="Hydrabad"},
                    new Employee{EmpId=4,EmpName="nimesh",EmpSal=40000,EmpLoc="pune"},
                    
            };
            foreach (Employee i in e)
            {
                    Console.WriteLine(i.EmpId + " " + i.EmpName + " " + i.EmpSal + " " + i.EmpLoc);
            }
            Console.ReadKey();
        }
    }
}