using System;


namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your Surname?");
            string surname = Console.ReadLine();

            Console.WriteLine("Give me a number:");
            string num = Console.ReadLine();

            int n = -1;

            bool success = Int32.TryParse(num, out n);

            if (success)
            {
                Console.WriteLine("Hello, " + name + " " + surname + ", " + "You have entered number: " + num);
               
            }

            else
            {
                Console.WriteLine("This is not a number!");
            }

            Console.Write("Press any key to exit");
            Console.ReadLine();



        }
    }
}
