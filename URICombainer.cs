using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication30
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Implement a program Combiner that takes two Strings as parameters and combines them, alternating 
             * letters, starting with the first letter of the first String, followed by the first letter of the 
             * second String, then second letter of first String, etc. The remaining letters of the longer String
             * are then appended to the end of the combination String and this combination String is returned.*/

            string input = Console.ReadLine();
            string[] inputList = input.Split(' ');
            char[] inputStr1 = inputList[0].ToCharArray();
            char[] inputStr2 = inputList[1].ToCharArray();
            int inputStr1Count = inputStr1.Count();
            int inputStr2Count = inputStr2.Count();

            string output = null;

            if (inputStr1Count >= inputStr2Count)
            {
                for (int i = 0; i < inputStr1Count; i++)
                {
                    if (i < inputStr2Count)
                    {
                        output = output + inputStr1[i].ToString() + inputStr2[i].ToString() ;
                    }
                    else
                    {
                        output = output + inputStr1[i].ToString();
                    }
                }
            }
            else
            {
                for (int i = 0; i < inputStr2Count; i++)
                {
                    if (i < inputStr1Count)
                    {
                        output = output + inputStr1[i].ToString() + inputStr2[i].ToString();
                    }
                    else
                    {
                        output = output + inputStr2[i].ToString();
                    }
                }
            }

           

            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
