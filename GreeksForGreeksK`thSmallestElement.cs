using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Given an array arr[] and a number K where K is smaller than size of array, the task is to find the Kth 
             * smallest element in the given array. It is given that all array elements are distinct.*/


            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for(int i =0; i<arr.Count(); i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

           

            for(int i=0; i<arr.Count()-1; i++)
            {
                 int min = i;
                for(int j=i+1; j<arr.Count(); j++)
                {
                    if(arr[j]<arr[min])
                    {
                        min = j;
                    }
                }

                if(min!=i)
                {
                    int temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }

            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(arr[k-1]);
            Console.ReadKey();
        }
    }
}
