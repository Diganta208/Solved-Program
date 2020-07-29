using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A sentence is called dancing if its first letter is uppercase and the case of each subsequent letter is the opposite 
            of the previous letter. Spaces should be ignored when determining the case of a letter. For example, "A b Cd" is a 
            dancing sentence because the first letter ('A') is uppercase, the next letter ('b') is lowercase, the next letter ('C') 
            is uppercase, and the next letter ('d') is lowercase.*/
            
            
            
            string input = Console.ReadLine();
            char[] inputStr = input.ToCharArray();
            string previousCarecter = null;
            string result = null;

            for(int i=0; i<inputStr.Count(); i++)
            {
                if(Char.IsLetter(inputStr[i]))
                {
                    if(previousCarecter==null)
                    {
                        
                           string s= inputStr[i].ToString();
                          string newS= s.ToUpper();
                          result = result + newS;
                           previousCarecter = "upper";
                     
                    }
                    else if(previousCarecter=="upper")
                    {
                        string s = inputStr[i].ToString();
                        string newS = s.ToLower();
                        result = result + newS;
                        previousCarecter = "Lower";
                    }
                    else
                    {
                        string s = inputStr[i].ToString();
                        string newS= s.ToUpper();
                        result = result + newS;
                        previousCarecter = "upper";
                    }

                   
                }
                else
                {
                    result = result + inputStr[i].ToString();
                }
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
