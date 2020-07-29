using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication35
{
    class Program
    {
        static void Main(string[] args)
        {

            int no = Convert.ToInt32(Console.ReadLine());
            int[] input = new int[no];

            for(int i=0; i<no; i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());
            }

            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            for (int i = 0; i < no; i++)
            {
                if(input[i]%2==0)
                {
                    even.Add(input[i]);
                }
                else
                {
                    odd.Add(input[i]);
                }
            }


            for (int i = 1; i < even.Count(); i++)  /*insertion sort*/
            {
                int item = even[i];

                int j = i - 1;

                while (j >= 0 && even[j] > item)
                {
                    even[j + 1] = even[j];
                    j = j - 1;


                }
                even[j + 1] = item;

            }

            for (int i = 1; i < odd.Count(); i++)    /*insertion sort*/
            {
                int item = odd[i];

                int j = i - 1;

                while (j >= 0 && odd[j] < item)
                {
                    odd[j + 1] = odd[j];
                    j = j - 1;


                }
                odd[j + 1] = item;

            }

            List<int> result = new List<int>();
            int m = 0;

            for(int i=0; i<no; i++)
            {
                if(i<even.Count())
                {
                    result.Add(even[i]);
                }
                else
                {
                    result.Add(odd[m]);
                    m++;
                }
            }


            Console.WriteLine("------------------------------------------");

            for(int i=0; i<no; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.ReadKey();



        }
    }
}
