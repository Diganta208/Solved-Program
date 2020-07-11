using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            /*An string of words is given, the task is to reverse the string using stack.*/



            string aString = Console.ReadLine();

            Char[] arr = aString.ToCharArray();

            Stack aStack = new Stack(arr.Count());

            for(int i=0; i<arr.Count(); i++)
            {
                aStack.push(arr[i]);
            }

            for (int i = 0; i < arr.Count(); i++)
            {
               char result= aStack.pop();
               Console.Write(result);

            }

            Console.ReadKey();

        }
    }
}
