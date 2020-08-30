using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication51
{
    class Program
    {
        static void Main(string[] args)
        {

            /*You are given a number of sticks of varying lengths. You will iteratively cut the sticks into smaller sticks, discarding the shortest
             * pieces until there are none left. At each iteration you will determine the length of the shortest stick remaining, cut that length 
             * from each of the longer sticks and then discard all the pieces of that shortest length. When all the remaining sticks are the same
             * length, they cannot be shortened so discard them.

            Given the lengths of n sticks, print the number of sticks that are left before each iteration until there are none left.

                For example, there are n=3  sticks of lengths a=[1,2,3]. The shortest stick length is 1, so we cut that length from the longer two and 
             * discard the pieces of length 1. Now our lengths are [1,2]. Again, the shortest stick is of length 1, so we cut that amount from the
             * longer stick and discard those pieces. There is only one stick left, a=[1] , so we discard that stick. Our lengths are answer=[3,2,1].*/

            int no = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[no];

            for(int i=0; i<no; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            List<int> result = new List<int>();

            int min = 1000;

            int count = 0;

            for(int i=0; i<arr.Count(); i++)
            {
                for(int j=0; j<arr.Count(); j++)
                {
                    if(arr[j]<min && arr[j]>0)
                    {
                        min = arr[j];
                    }
                }

                for(int k=0; k<arr.Count(); k++)
                {
                    if(arr[k]>0)
                    {
                        count++;
                    }
                   arr[k] = arr[k] - min;
                }



                if(count==0)
                {
                    break;
                }


                result.Add(count);
                min = 1000;
                count = 0;
            }

            for(int i=0; i<result.Count(); i++)
            {
                Console.Write(result[i] + "  ");
            }

            Console.ReadKey();
        }
    }
}
