using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_hand
{
    class File_hand_q2
    {
        static void Main(string[] args)
        {
            int ch;
            string name,branch;
            int acc_no;
            void insert()
            {
                FileStream fs = new FileStream("e:\\sec_asmngt.txt", 				    FileMode.Append, FileAccess.Write);
                StreamWriter w = new StreamWriter(fs);
                Console.WriteLine("Enter Your Name:");
                name = Console.ReadLine();
                w.Write(name + " ");
                Console.WriteLine("Enter Your Branch Name:");
                branch = Console.ReadLine();
                w.Write(branch + " ");
                Console.WriteLine("Enter Your Account Number:");
                acc_no = Convert.ToInt32(Console.ReadLine());
                w.Write(acc_no + " ");
                w.WriteLine(Environment.NewLine);
                Console.WriteLine("Record Inserted Succefully.");
                w.Flush();
                fs.Close();
            }
            void show()
            {
                Console.WriteLine("\n\n File Content:\n");
                var lines = File.ReadAllLines("e:\\sec_asmngt.txt");
                for (var i = 0; i < lines.Length; i += 1)
                {
                    var line = lines[i];
                    Console.WriteLine(line);
                }
               // Console.ReadKey();
            }
            while(true)
            {
                Console.WriteLine("\n---------Menu----------\n");
                Console.WriteLine("1) Press 1 To insert New Record into file:");
                Console.WriteLine("2) Press 2 For Show Content in File:");
                Console.WriteLine("3) Press 3 To Exit From Menu:");
                Console.WriteLine("Enter Your Choice :");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {

                    case 1:
                        insert();
                        break;
                    case 2:
                        show();
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;

                }

            }


        }
    }
}

