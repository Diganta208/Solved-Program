using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Program
    {
        static void Main(string[] args)
        {
            /*For years, all contracts of the Association of Contracts for Modernization (ACM) were typed using an old typewriter machine.

          Recently Mr. Miranda, one of the accountants of the ACM, realized that the machine had a failure in one, and only one, numerical 
             * digit. More specifically, the flawed digit, when typed, is not printed on the sheet, as if the corresponding key was not 
             * pressed. He realized that this could have changed the numerical representation of contract values. Worried about accounting,
             * Mr. Miranda wants to know, from the original values agreed for the contracts (which he kept in handwritten notes) which
             * values are actually represented in the contracts. For example, if the failed digit in the machine is 5, an agreed value of 
             * 1500 would be represented in the corresponding contract as 100, because the digit 5 would not be printed. Note that Mr. Miranda 
             * wants to know the numeric value represented in the contract, ie, in the same machine, the number 5000 corresponds to the numeric
             * value 0, not 000 (as it actually appears in the contract).*/



            string input = Console.ReadLine();
            string[] inputArr = input.Split(' ');

            string output= null;
            char[] inputOne = inputArr[0].ToCharArray();
            char[] inputTwo = inputArr[1].ToCharArray();

            for(int i=0; i<inputTwo.Count(); i++)
            {
                if(inputTwo[i]!=inputOne[0])
                {
                    output = output + inputTwo[i].ToString();
                }
            }

            if(output==null)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(Convert.ToInt32(output));
            }
            Console.ReadKey();
        }
    }
}
