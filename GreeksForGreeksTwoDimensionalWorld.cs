using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication36
{
    class Program
    {
        static void Main(string[] args)
        {

            /*In CPP we can't pass 2D arrays in normal way to a function. The array has to be declared in a special way.

          Given a 2D array A[ ][ ] of size N x N consisting of integers. The task is to print all the elements in matrix
             * (row and column order) form.*/



            int no = Convert.ToInt32(Console.ReadLine());
            int[,] input= new int[no,no];

            for(int i=0; i<no; i++)
            {
                for(int j=0; j<no; j++)
                {
                    input[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("---------------------------");

            for (int i = 0; i < no; i++)
            {
                for (int j = 0; j < no; j++)
                {
                    Console.Write(input[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
