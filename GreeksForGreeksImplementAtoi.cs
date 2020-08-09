using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication45
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Your task  is to implement the function atoi. The function takes a string(str) as argument and converts it to an integer and returns it.
 
             Input:
             The first line of input contains an integer T denoting the no of test cases . Then T test cases follow. Each test 
             * case contains a string str .
             Output:
             For each test case in a new line output will be an integer denoting the converted integer, if the input string is not a
             * numerical string then output will be -1.*/

            string input = Console.ReadLine();
            char[] inputStr = input.ToCharArray();

            int result=0;

            for(int i=0; i<inputStr.Count(); i++)
            {
                if(Char.IsNumber(inputStr[i]))
                {
                    result = 1;
                }
                else
                {
                    result = -1;
                    break;
                }
            }

            if(result==1)
            {
                Console.WriteLine(Convert.ToInt32(input));
            }
            else
            {
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
