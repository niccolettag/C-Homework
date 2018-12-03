using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            Console.WriteLine("Hi! Enter a year:");
            bool Valid = false;
            int year;
            while (Valid == false)
            {
                string Input = Console.ReadLine();
                if (int.TryParse(Input, out year))
                {
                    Valid = true;
                    if (year % 400 == 0 || year % 100 != 0 && year % 4 == 0)
                    {
                        Console.WriteLine("Leap Year");
                    }
                    else
                    {
                        Console.WriteLine("Common Year");
                    }
                }
                else
                {
                    Console.WriteLine("Not a year, please enter a year!");
                }
            }
            Console.WriteLine("Press double ENTER");
            Console.ReadKey();
            Console.ReadLine();
            goto Start;
        }
    }
}
