using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication28
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Given an unsorted array A of size N of non-negative integers, find a continuous sub-array which adds to a given number S.*/

            int[] arr = new int[2];

            for (int i = 0; i < arr.Count(); i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] input = new int[arr[0]];

            for (int i = 0; i < input.Count(); i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());

            }

            int[] result = new int[2];

            for(int i = 0; i < input.Count()-1; i++)
            {
                int sum = input[i];
                
                for(int j = i+1; j < input.Count(); j++)
                {
                    sum = sum + input[j];
                    if(sum==arr[1])
                    {
                        result[0] = i + 1;
                        result[1] = j + 1;
                        break;
                    }
                    else if(sum>arr[1])
                    {
                        break;

                    }
                    else
                    {
                        continue;
                    }
                }

                if(sum==arr[1])
                {
                    break;
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
