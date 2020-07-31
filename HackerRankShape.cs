using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication39
{
    class Program
    {
        static void Main(string[] args)
        {
            int no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            for (int j = 0; j < no; j++)
            {
                for (int i = 0; i < no; i++)
                {
                    if (i == j)
                    {
                        Console.Write("*" + " ");
                    }
                    else if (i == no - j - 1)
                    {
                        Console.Write("*" + " ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }

                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
