using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Given an array of positive integers. The task is to find inversion count of array.

             Inversion Count : For an array, inversion count indicates how far (or close) the array
             * is from being sorted. If array is already sorted then inversion count is 0. If array
             * is sorted in reverse order that inversion count is the maximum. 
               Formally, two elements a[i] and a[j] form an inversion if a[i] > a[j] and i < j.*/


            int n = Convert.ToInt32(Console.ReadLine());
            int[] first = new int[n];

            for (int i = 0; i < first.Count(); i++)
            {
                first[i] = Convert.ToInt32(Console.ReadLine());

            }

            int count = 0;

            for (int i = 0; i < first.Count()-1; i++)
            {
                for (int j = i+1; j < first.Count(); j++)
                {
                   if(first[i]>first[j])
                   {
                       count++;
                   }
                }

            }

            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
