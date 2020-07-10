using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Given an array arr of N integers. Find the contiguous sub-array with maximum sum.*/


            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for(int i=0; i< arr.Count(); i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int maxSum = -100;

            int sum = 0;


            for(int i=0; i<arr.Count()-1; i++)
            {
                sum = arr[i];
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
                for(int j=i+1; j<arr.Count(); j++)
                {
                    sum = sum + arr[j];
                    if(sum>maxSum)
                    {
                        maxSum = sum;
                    }

                }

                sum = 0;

            }

            Console.WriteLine(maxSum);
            Console.ReadKey();
        }
    }
}
