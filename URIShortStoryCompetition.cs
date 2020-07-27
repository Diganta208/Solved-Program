using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication29
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Machado wants to be a writer. He has written many short stories, book reviews, reports of trips he made, 
             * and a little romance. Now Machado wants to take part in a short story competition, which has very strict 
             * rules about the submission format. The rules of the competition limit the number of total pages, and specify 
             * the maximum number of characters per line, and the maximum number of lines per page. Additionally, each word
             * must be written integrally in one line (ie, a word cannot be separated in two lines). Machado wants to write
             * a story with as many words as possible within the rules of the contest, and needs your help. Given the maximum 
             * number of characters per line, the maximum number of lines per page, and the words of the short story that Machado 
             * is writing, he wants to know the minimum number of pages that his short story will ocuppy, considering the rules
             * of the contest.*/

            int[] format = new int[3];

            for(int i=0; i<format.Count(); i++)
            {
                format[i] =Convert.ToInt32( Console.ReadLine());
            }

            string input = Console.ReadLine();

            char[] inputArr = input.ToCharArray();

            int charecters = inputArr.Count();
            int words = 1;

            for (int i = 0; i < inputArr.Count(); i++)
            {
                if(inputArr[i]==' ')
                {
                    words++;
                }
            }
            int useCharecter = 0;
           
            int useLine=1;
            int usePage=1;

            for (int i = 0; i < charecters; i++)
            {
                
                if (useCharecter == format[0])
                {
                    
                    useLine++;
                    useCharecter = 1;
                    if(useLine>format[2])
                    {
                        usePage++;
                        useLine = 1;
                    }
                    
                }
                
                else 
                {
                    useCharecter++; 
                }
            }

            Console.WriteLine(usePage);
            Console.ReadKey();

           
        }
    }
}
