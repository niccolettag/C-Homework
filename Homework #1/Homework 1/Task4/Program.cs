using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int a, b, c, d, sum;
            float avg;

            Console.WriteLine("Give 1 number:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Give 2 number:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Give 3 number:");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Give 4 number:");
            d = int.Parse(Console.ReadLine());

            sum = a + b + c + d;
            avg = sum / 4;

            Console.WriteLine("The average of { 0}, { 1}, { 2}, { 3} is: { 4}", a, b, c, d, avg);
        }
    }
}
