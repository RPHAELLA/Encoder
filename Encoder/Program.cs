using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Source code directory (full path): ");
            Console.Out.Flush();
            var location = Console.ReadLine();
            Console.Write("File extension (e.g. .cs): ");
            Console.Out.Flush();
            var extension = Console.ReadLine();

            // Convert to UTF-8
            /*
             * Example of location: @"C:\Users\X\Desktop\Source")
             * Example of extension: *.cpp
             * 
             */
            foreach (var f in new DirectoryInfo(location).GetFiles("*" + extension, SearchOption.AllDirectories))
            {
                string s = File.ReadAllText(f.FullName);
                Console.WriteLine("[*] Converting file: " + f.FullName);
                File.WriteAllText(f.FullName, s, Encoding.UTF8);
            }
            Console.WriteLine("Operation completed");
        }
    }
}
