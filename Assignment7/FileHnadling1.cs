using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment7
{
    internal class Program
    {
        static void Main()
        {
            var lines = File.ReadAllLines("f:\\file_handling.txt");
            for (var i = 0; i < lines.Length; i += 1)
            {
                var line = lines[i];
                Console.WriteLine(line);
            }
            Console.WriteLine("\nFolders in This Drive : \n\n");
            DirectoryInfo di = new DirectoryInfo("c:\\");
            DirectoryInfo[] diArr = di.GetDirectories();
            foreach (DirectoryInfo dri in diArr)
                Console.WriteLine(dri.Name);
            Console.ReadKey();
        }
    }
}




    

