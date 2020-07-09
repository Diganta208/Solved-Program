using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Suppose you have two pets and you love both of them very much. You go to a pet store to buy
             * different articles for your pets. But you ask salesman that you will buy only those articles
             * which are actually in pair. In this store, articles are referred as integers. So you have to 
             * tell total no. of articles you will buy for your pets.*/



            int ab = Convert.ToInt32(Console.ReadLine());


            int[] input= new int[ab];

            for(int i=0; i<input.Count(); i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());
            }

            int pair=0;

            for(int i=0; i<input.Count()-1; i++)
            {
                for (int j = i+1; j < input.Count(); j++)
                {
                    if(input[i]==input[j])
                    {
                        pair++;
                        break;
                    }
                    else
                    {
                        break;

                    }
                }
            }

            Console.WriteLine(pair * 2);
            Console.ReadKey();
        }
    }
}
