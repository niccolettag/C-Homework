using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int temp;

            Console.WriteLine("Give 1st number");
            int v1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me 2nd number");
            int v2 = int.Parse(Console.ReadLine());

            temp = v1;
            v1 = v2;
            v2 = temp;

            Console.Write("After swapping:");
            Console.Write("First Number: " + v1);
            Console.Write("Second Number: " + v2);
            
            Console.ReadLine();
        }
    }
}
