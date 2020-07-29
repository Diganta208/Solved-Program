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
