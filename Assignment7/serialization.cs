using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_hand
{
    [Serializable]
    abstract class Employee
    {
        public abstract void getdetails();
        public abstract void showdetails();
    }
    [Serializable]
    class manager : Employee
    {
        public int empid;
        public string empname;

        public override void getdetails()
        {
            Console.WriteLine("Enter Your Employess Id:");
            empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Employess Name:");
            empname = Console.ReadLine();
            //Console.ReadKey();
        }
        public override void showdetails()
        {
            Console.WriteLine("Your Employee Id is {0}", empid);
            Console.WriteLine("Your Employee Name  is {0}", empname);
            //Console.ReadKey();
        }
    }
    [Serializable]
    class marketexe : Employee
    {
        public int empid;
        public string empname;

        public override void getdetails()
        {
            Console.WriteLine("Enter Your Employess Id:");
            empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Employess Name:");
            empname = Console.ReadLine();
            //Console.ReadKey();
        }
        public override void showdetails()
        {
            Console.WriteLine("Your Employee Id is {0}", empid);
            Console.WriteLine("Your Employee Name  is {0}", empname);
            //Console.ReadKey();
        }
    }



    class File_hand_q3
    {
        static void Main()
        {
            manager mg = new manager();
            marketexe mk = new marketexe();
            FileStream stream = new FileStream("e:\\example.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();


            formatter.Serialize(stream, mg);
            Console.WriteLine();
            formatter.Serialize(stream, mk);

            stream.Close();

        }
    }
}
