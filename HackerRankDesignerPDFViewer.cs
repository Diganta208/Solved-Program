using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication42
{
    class Program
    {
        static void Main(string[] args)
        {
            /*When you select a contiguous block of text in a PDF viewer, the selection is highlighted with a blue rectangle. 
             * In this PDF viewer, each word is highlighted independently. For example:



       In this challenge, you will be given a list of letter heights in the alphabet and a string. Using the letter heights
             * given, determine the area of the rectangle highlight in  assuming all letters are  wide.

        For example, the highlighted word= torn . Assume the heights of the letters are t=2, o=1, r=1 and n=1 . The tallest 
             * letter is t=2 high and there are 4 letters. The hightlighted area will be 2*1*4=8 so the answer is 8 .*/
           

            char[] charecters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            

            Console.Write("Input : ");
            string input = Console.ReadLine();



            char[] inputArr = input.ToCharArray();

            Console.WriteLine("Values :");

            int[] values = new int[26];

            for (int i = 0; i < values.Count(); i++)
            {
                values[i] = Convert.ToInt32(Console.ReadLine());
            }


            int index;
            int maxIndex = 0;

            int width = 1;

            for(int i=0; i<inputArr.Count(); i++)
            {
                for(int j=0; j<charecters.Count(); j++)
                {
                    if(inputArr[i]== charecters[j])
                    {
                        index = values[j];

                        if(index>maxIndex)
                        {
                            maxIndex = index;
                        }
                    }
                }
            }

            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine(maxIndex * width * inputArr.Count());
            Console.ReadKey();
        }
    }
}
