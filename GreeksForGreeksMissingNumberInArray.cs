using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Given an array C of size N-1 and given that there are numbers from 1 to N with one element missing, the missing number is to be found.*/



           int no= Convert.ToInt32(Console.ReadLine());
           int[] arr={1, 3, 4, 5};

            for(int i=1; i<=no; i++)
            {
                if(arr.Contains(i))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
