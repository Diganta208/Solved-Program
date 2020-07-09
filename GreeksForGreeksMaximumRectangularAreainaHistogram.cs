using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Find the largest rectangular area possible in a given histogram where the largest rectangle 
             * can be made of a number of contiguous bars. For simplicity, assume that all bars have same width and the width is 1 unit.*/

            int no = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[no];

            for(int i=0; i<arr.Count(); i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int MaxArea = 0;

            for(int i=0; i<arr.Count(); i++)
            {

                int count= 1;
                for(int j=i-1; j>0; j--)
                {
                    if (arr[i] == arr[j] || arr[j] > arr[i])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }                

                for (int m = i+1; m < arr.Count(); m++)
                {
                    if (arr[i] == arr[m] || arr[m] > arr[i])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                int area = count * arr[i];

                if(area>MaxArea)
                {
                    MaxArea = area;
                }
            }


            Console.WriteLine(MaxArea);
            Console.ReadKey();
        }
    }
}
