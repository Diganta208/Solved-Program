using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication44
{
    class Program
    {
       
        static void Main(string[] args)
        {

            /* Louise joined a social networking site to stay in touch with her friends. The signup page required her to input a 
             * name and a password. However, the password must be strong. The website considers a password to be strong if it
             * satisfies the following criteria:

           Its length is at least 6.
           It contains at least one digit.
           It contains at least one lowercase English character.
           It contains at least one uppercase English character.
           It contains at least one special character. The special characters are: !@#$%^&*()-+
           She typed a random string of length n in the password field but wasn't sure if it was strong. Given the string she
             * typed, can you find the minimum number of characters she must add to make her password strong?

           Note: Here's the set of types of characters in a form you can paste in your solution:

           numbers = "0123456789"
           lower_case = "abcdefghijklmnopqrstuvwxyz"
           upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
           special_characters = "!@#$%^&*()-+"*/

            string input = Console.ReadLine();

            char[] inputStr = input.ToCharArray();

            int change = 0;

            int lowerCase = 0;
            int upercase = 0;
            int digit = 0;
            int spatial = 0;

            

            if(inputStr.Count()<6)
            {
                change = 6 - inputStr.Count();
                Console.WriteLine(change);
                Console.ReadKey();
            }

            else
            {
                for(int i=0; i< inputStr.Count(); i++)
                {
                    if(Char.IsLower(inputStr[i]))
                    {
                        lowerCase++;

                    }
                    else if(Char.IsUpper(inputStr[i]))
                    {
                        upercase++;
                    }
                    else if (Char.IsNumber(inputStr[i]))
                    {
                        digit++;
                    }
                    else
                    {
                        spatial++;
                    }
                }

                if(lowerCase == 0)
                {
                    change++;
                }
                if(upercase==0)
                {
                    change++;
                }
                if(digit==0)
                {
                     change++;
                }
                if(spatial==0)
                {
                    change++;
                }

                Console.WriteLine(change);
                Console.ReadKey();

            }
        }
    }
}
