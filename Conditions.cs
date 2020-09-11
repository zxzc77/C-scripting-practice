using System;

namespace Conditions_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01;
            int num02;
            double num03;

            Console.WriteLine("Hello. If you can answer these three math questions I'll give you nothing. \nFirst question. \n3 + 5 - 2 = ?");
            num01 = Convert.ToInt32(Console.ReadLine());

            if (num01 == 6){
                Console.WriteLine("Well done. Next one. \n6 x 2 + 5 = ?");
                num02 = Convert.ToInt32(Console.ReadLine());

                if (num02 == 17){
                    Console.WriteLine("Well done. Last one. \n4.5 + 3.2 - 7 = ?");
                    num03 = Convert.ToDouble(Console.ReadLine());

                    if (num03 == .7){
                        Console.WriteLine("Congrats fucko, you win");
                    }
                    else{
                        Console.WriteLine("So close.");
                    }
                }
                else{
                    Console.WriteLine("Nope");
                }
            }
            else{
                Console.WriteLine("How'd you fuck that up?");
            }
        }
    }
}
