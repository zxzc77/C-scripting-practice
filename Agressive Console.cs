using System;

namespace Random_practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName;
            string truePlayerName;
            int num01;
            int num02;
            int trigger = 0;

            Console.WriteLine("Sup bitch? \nAlright first thing's first, what's your name?");
            playerName = Console.ReadLine();

            Console.WriteLine(playerName + " huh? Well that name sucks so I'mma keep calling you Bitch. That ok?");
            Console.ReadLine();
            Console.WriteLine("Ok Bitch. Right first thing's first, what's 2 + 2?");
            num01 = Convert.ToInt32(Console.ReadLine());

            if (num01 == 4)
            {
                Console.WriteLine("Thanks nerd. \nNext question, what did you say your name was again?");
                truePlayerName = Console.ReadLine();
                if (truePlayerName == "Bitch")
                {
                    Console.WriteLine("Awesome you didn't forget.");
                    trigger = 1;
                }
                else if (truePlayerName == playerName)
                {
                    Console.WriteLine("Listen I already said you're Bitch now, don't be a knuckle dragger about this.");
                    trigger = 1;
                }
                else
                {
                    Console.WriteLine("Are you rtarded? Neither of us have said that and we've both giving a name at this point.");
                }
            }
            else
            {
                Console.WriteLine("Wow you suck at this huh?");
            }

            if (trigger == 1)
            {
                Console.WriteLine("Alright here's the final question. \nWhat is 7 - 7 + 5?");
                num02 = Convert.ToInt32(Console.ReadLine());

                if (num02 == 5)
                {
                    Console.WriteLine("Thanks for doing my homework, nerd.");
                }
                else
                {
                    Console.WriteLine("Are you ill?");
                }
            }
        }
    }
}
