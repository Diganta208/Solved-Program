using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Given a number N, Write a program to find a number which is greater than or equal to N and is a smallest power of 2.*/



            int n = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                int po = Convert.ToInt32(Math.Pow(2,i));

                if(po>=n)
                {
                    Console.WriteLine(po);
                    break;
                }

            }

            Console.ReadKey();
        }
    }
}
