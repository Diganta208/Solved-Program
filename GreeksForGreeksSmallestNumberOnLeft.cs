using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Given an array of integers, find the nearest smaller number for every element such that the smaller 
             * element is on left side.If no small element present on the left print -1.*/


            int n = Convert.ToInt32(Console.ReadLine());

            int[] input = new int[n];

            for(int i=0; i<n; i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());

            }

            List<int> result = new List<int>();

            

            for (int i = 0; i < n; i++)
            {

                if(i==0)
                {
                    result.Add(-1);
                }
                else
                {
                    int small = 0;

                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (input[j] < input[i])
                        {
                            result.Add(input[j]);
                            small++;
                            break;
                        }
                    }

                    if (small == 0)
                    {
                        result.Add(-1);
                    }
                }
                

            }


            for (int i = 0; i < result.Count(); i++)
            {
                Console.Write(result[i] + " ");

            }


            Console.ReadKey();
        }
    }
}
