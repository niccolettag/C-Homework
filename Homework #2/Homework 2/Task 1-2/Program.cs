using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");

            int n1 = 0;
            string i1 = Console.ReadLine();

            while (!int.TryParse(i1, out n1))
            {
                Console.WriteLine("This is not a number, please provide a number");
                i1 = Console.ReadLine();
            }

            Console.WriteLine("Enter second number");
            int n2 = 0;
            string i2 = Console.ReadLine();

            while (!int.TryParse(i2, out n2))
            {
                Console.WriteLine("This is not a number, please provide a number");
                i2 = Console.ReadLine();
            }

            Console.WriteLine("Enter third number");
            int n3 = 0;
            string i3 = Console.ReadLine();

            while (!int.TryParse(i3, out n3))
            {
                Console.WriteLine("This is not a number, please provide a number");
                i3 = Console.ReadLine();
            }

            int[] array = { n1, n2, n3 };
            int max = array.Max();

            Console.WriteLine("The maximum number out of {0}; {1}; {2} is: {3}", n1, n2, n3, max);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
