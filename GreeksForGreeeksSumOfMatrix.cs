using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication56
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Row No");
            int i= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Coloumn No");
            int j= Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[i, j];
            
            Console.WriteLine("Please Enter Value of 2d array");

            for (int m = 0; m < i; m++)
            {
                for (int n = 0; n < j; n++)
                {
                    arr[m, n] = Convert.ToInt32(Console.ReadLine());
                }
            }


            for(int m=0; m<i; m++)
            {
                for(int n=0; n<j; n++)
                {
                    Console.Write(arr[m, n] + " ");
                }

                Console.WriteLine();
            }

       
            Console.ReadKey();

        }
    }
}
