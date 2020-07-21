using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Given an array of positive integers. Your task is to find the leaders in the array.
             Note: An element of array is leader if it is greater than or equal to all the elements to its right side. 
             * Also, the rightmost element is always a leader. */




            int n = Convert.ToInt32(Console.ReadLine());

            int[] input = new int[n];
            for (int i = 0; i < input.Count(); i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());

            }

            List<int> result = new List<int>();
            result.Add(input[input.Count() - 1]);

            for(int i=0; i< input.Count()-1; i++)
            {
                int no = input[i];

                for(int j=i+1; j<input.Count(); j++)
                {
                    if(no>=input[j])
                    {
                        if (j == input.Count()-1)
                        {
                            result.Add(no);
                        }
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            result.Add(input[input.Count() - 1]);

            for (int i = 0; i < result.Count(); i++)
            {
                Console.Write(result[i] + " ");

            }

            Console.ReadKey();
        }
    }
}
