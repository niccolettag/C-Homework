using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int mf, res;

            Console.WriteLine("Give me a number:");
            int num = int.Parse(Console.ReadLine());

            for (mf=0; mf<=10; mf++ )
            {
                res = num * mf;
                Console.WriteLine("{0}*{1}={2}", num, mf, res);
            }

            Console.ReadLine();

        }
    }
}
