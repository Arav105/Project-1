using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Path to the text file
            string path =" G:\\Project - 1\\student details.txt";
            string studentfile = File.ReadAllText(path);
            Console.WriteLine(studentfile);
            Console.ReadLine();
        }
    }
    
}
