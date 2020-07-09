using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] first = new int[2];
            for (int i = 0; i < first.Count(); i++)
            {
                first[i] = Convert.ToInt32(Console.ReadLine());

            }

            int[] input = new int[first[0]];
            int[] output = new int[first[0]];
            for (int i = 0; i < input.Count(); i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < input.Count(); i++)
            {


                if (i >= first[1])
                {
                    int position = i - first[1];
                    output[position] = input[i];
                }

                else
                {
                    int position = first[0] - (first[1]-i);
                    output[position] = input[i];
                }

            }

            for (int i = 0; i < input.Count(); i++)
            {
                Console.Write(output[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
