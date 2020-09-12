using System;

namespace Array_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int s;

            Console.WriteLine("How many students are in the class?");
            s = Convert.ToInt32(Console.ReadLine());
            string[] students = new string[s];

            Console.WriteLine("Please type in all " + s + " names.");

            for (int i = 0; i < students.Length; i++)
            {
                students[i] = Console.ReadLine();
            }

            Console.WriteLine("\nHere are your students alphetabetically.");

            Array.Sort(students);

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
        }
    }
}
