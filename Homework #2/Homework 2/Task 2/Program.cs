using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, rows, k = 1;
            int sp;

            Console.Write("Input number of rows : ");

                rows = Convert.ToInt32(Console.ReadLine());
                for (i = 1; i <= rows; i++)
                {
                    for (sp = 1; sp <= (rows - i); sp++)
                    {
                        Console.Write(" ");
                    }

                    for (j = 1; j <= i; j++)
                    {
                        Console.Write("{0} ", k++);
                    }
                        
                    Console.Write("\n");
                }
                
                Console.ReadLine();         
        }
    }
}
