using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication43
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Watson likes to challenge Sherlock's math ability. He will provide a starting and ending value describing a range of integers. 
             * Sherlock must determine the number of square integers within that range, inclusive of the endpoints.*/

            Console.WriteLine("Enter the Ramge :");

            int[] range = new int[2];

            for(int i=0; i<range.Count(); i++)
            {
                range[i] = Convert.ToInt32(Console.ReadLine());
            }

            int no1 = Convert.ToInt32(Math.Sqrt(range[0]));
            int no2 = Convert.ToInt32(Math.Sqrt(range[1]));
            int result= 0;

            for(int i=no1; i<= no2; i++)
            {
                bool Isint = (i * i) % 1 == 0;

                if(Isint && (i * i)>=range[0] &&  (i * i)<=range[1])
                {
                    result++;
                }
            }

            Console.WriteLine(result);
            Console.ReadKey();


        }
    }
}
