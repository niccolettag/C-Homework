using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter X coordinate");

            int x = 0;
            string i1 = Console.ReadLine();

            while (!int.TryParse(i1, out x))
            {
                Console.WriteLine("This is not a number, please provide a number");
                i1 = Console.ReadLine();
            }

            Console.WriteLine("Enter Y coordinate");

            int y = 0;
            string i2 = Console.ReadLine();

            while (!int.TryParse(i2, out y))
            {
                Console.WriteLine("This is not a number, please provide a number");
                i2 = Console.ReadLine();
            }

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Point is in the I Quadrant");
            }

            if (x < 0 && y > 0)
            {
                Console.WriteLine("Point is in the II Quadrant");
            }

            if (x < 0 && y < 0)
            {
                Console.WriteLine("Point is in the III Quadrant");
            }

            if (x > 0 && y < 0)
            {
                Console.WriteLine("Point is in the IV Quadrant");
            }

            if (x == 0 && y > 0)
            {
                Console.WriteLine("Point is at the border of I and II Quadrant");
            }

            if (x < 0 && y == 0)
            {
                Console.WriteLine("Point is at the border of II and III Quadrant");
            }

            if (x == 0 && y < 0)
            {
                Console.WriteLine("Point is at the border of III and IV Quadrant");
            }
            if (x > 0 && y == 0)
            {
                Console.WriteLine("Point is at the border of I and IV Quadrant");
            }

            if (x == 0 && y == 0)
            {
                Console.WriteLine("The point does not lie in any of the quadrants");
            }

            Console.ReadKey();
        }
    }
}
