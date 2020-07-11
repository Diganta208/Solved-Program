using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Given a string s, find the minimum number of changes required to it so that all substrings of the string become distinct.*/



            string input = Console.ReadLine();
            char[] CharArr = input.ToCharArray();

            List<char> Result = new List<char>();

            int count = 0;

            for(int i=0; i<CharArr.Count(); i++)
            {
                if(Result.Contains(CharArr[i]))
                {
                    count++;
                }
                else
                {
                    Result.Add(CharArr[i]);
                }
            }

            Console.WriteLine(count);

            Console.ReadKey();
        }
    }
}
