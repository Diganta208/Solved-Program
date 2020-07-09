using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Given a binary string S. The task is to count the number of substrings that 
             * start and end with 1. For example, if the input string is “00100101”, then there are three substrings “1001”, “100101” and “101”. */

            string input = Console.ReadLine();

            int count = 0;

            char[] Converter = input.ToCharArray();

            for(int i=0; i<Converter.Count()-1; i++)
            {
                if(Converter[i]=='1')
                {
                    for (int j = i+1; j < Converter.Count(); j++)
                    {
                        if(Converter[j]=='1')
                        {
                            count++;
                        }
                        else
                        {
                            continue;
                        }

                    }
                }
                else
                {
                    continue;
                }
               
            }

            Console.WriteLine(count);
            Console.ReadKey();


        }
    }
}
