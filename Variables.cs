using System;
using System.IO.MemoryMappedFiles;

namespace Veriable_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            double num01;
            double num02;
            double num03;
            string userName;
            Console.WriteLine("Alright bith, what's your name?");
            userName = Console.ReadLine();

            Console.WriteLine(userName + " huh? Alright give me three numbers and I'll give you the average. \nFirst number?");
            num01 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Alright give us another.");
            num02 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("One more");
            num03 = Convert.ToDouble(Console.ReadLine());

            double result = (num01 + num02 + num03) / 3;
            Console.WriteLine("Right. Check this shit out, " + userName + "\n" + result);
        }
    }
}
