using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Given two numbers as stings s1 and s2 your task is to multiply them. You are required to 
             * complete the function multiplyStrings which takes two strings s1 and s2 as its only argument 
             * and returns their product as strings.*/



            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int ans = a * b;

            string StringAns = ans.ToString();
            Console.WriteLine(StringAns);
            Console.ReadKey();
        }
    }
}
