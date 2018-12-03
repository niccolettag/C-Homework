using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter series number");

            int x = 0;
            string inp = Console.ReadLine();
            long s = 0;
            long t = 1;
            

            while (!int.TryParse(inp, out x))
            {
                Console.WriteLine("This is not a number, please provide a number");
                inp = Console.ReadLine();
            }

            for (int i = 0; i < x && t > 0 && s>=0; i++)
            {
                Console.Write("{0} + ", t);
                t = (t * 10) + 1;
                s = s + t;
            }

            if (t < 0 && s<0)
            {
                Console.WriteLine("You excided integer maxValue for elements and sum");  
            }
            else if (s>0)
            {
                Console.Write("\nThe Sum is: {0}\n", s);
            }
            
            Console.ReadKey();

        }
    }
}
