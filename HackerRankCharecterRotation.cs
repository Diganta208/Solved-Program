using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication54
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input a String :");
            string input = Console.ReadLine();



            char[] inputStr = input.ToCharArray();

            string result = null;

            for(int i=0; i<inputStr.Count(); i++)
            {
                
                if(inputStr[i]=='x'|| inputStr[i]=='y'|| inputStr[i]=='z'||inputStr[i]=='X'|| inputStr[i]=='Y'|| inputStr[i]=='Z')
                {
                    int value = Convert.ToInt32(inputStr[i]) - 23;
                    char temp = Convert.ToChar(value);
                    result = result + temp.ToString();

                }
                else
                {
                    int value = Convert.ToInt32(inputStr[i]) + 3;

                    char temp = Convert.ToChar(value);
                    result = result + temp.ToString();
                }
               
            }
            Console.WriteLine("Rotate String :");

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
