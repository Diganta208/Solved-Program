using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication31
{
    class Program
    {
        static void Main(string[] args)
        {

            /*You have been asked to build a simple encryption program. This program should be able to send coded messages
             * without someone been able to read them. The process is very simple. It is divided into two parts.

              First, each uppercase or lowercase letter must be shifted three positions to the right, according to the ASCII table:
             * letter 'a' should become letter 'd', letter 'y' must become the character '|' and so on. Second, each line must be
             * reversed. After being reversed, all characters from the half on (truncated) must be moved one position to the left in ASCII. 
             * In this case, 'b' becomes 'a' and 'a' becomes '`'.

             For example, if the resulting word of the first part is "tesla", the letters "sla" should be moved one position to the left. 
             * However, if the resulting word of the first part is "t#$A", the letters "$A" are to be displaced.*/


            string input = Console.ReadLine();
            char[] inputStr = input.ToCharArray();
            string reverse = null;

             for(int i=inputStr.Count()-1; i>=0; i--)
             {
                 reverse = reverse + inputStr[i].ToString();
             }

            string output = null;

            for (int i = 0; i < reverse.Count(); i++)
            {

                if(i==0)
                {
                    if (Char.IsLetter(reverse[i]))
                    {
                        char first = reverse[i];
                        char nextChar = (char)((int)first + 3);
                        output = output + nextChar.ToString();
                    }
                    else
                    {
                        output = output + reverse[i].ToString();
                    }
                }
                else if (i < reverse.Count()/2)
                {
                    if (Char.IsLetter(reverse[i]))
                    {
                        char first = reverse[i];
                        char nextChar = (char)((int)first + 3);
                        output = output + nextChar.ToString();
                    }
                    else
                    {
                        output = output + reverse[i].ToString();
                    }
                }
                else
                {
                       if (Char.IsLetter(reverse[i]))
                       {
                           char previousChar = (char)((int)reverse[i] +2);
                           output = output + previousChar.ToString();
                       }
                       else
                       {
                           output = output + reverse[i].ToString();
                       }
                 
                }
               
            }

            Console.WriteLine(output);
            Console.ReadKey();

        }
    }
}
