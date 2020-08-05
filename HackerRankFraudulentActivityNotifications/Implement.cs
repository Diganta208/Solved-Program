using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication40
{
    class Implement
    {

        public void Sort(int[] arr)
        {
           


            for (int i = 1; i < arr.Count(); i++)
            {
                int item = arr[i];

                int j = i - 1;

                while (j >= 0 && arr[j] > item)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;


                }
                arr[j + 1] = item;


            }
  
        }

        public int Mean(int[] arr)
        {
            int no = arr.Count();
            int median;
            

            if(no%2==0)
            {
                int no1 = arr.Count() / 2;
                int no2 = no1 - 1;
                median = (arr[no1] + arr[no2]) / 2;
                return median;


            }
            else
            {
                median = arr[arr.Count() / 2];
                return median;
            }
        }
    }
}
