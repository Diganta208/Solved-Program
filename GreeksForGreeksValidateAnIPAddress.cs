using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication46
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Write a program to Validate an IPv4 Address. According to Wikipedia, IPv4 addresses are canonically represented in dot-decimal notation, 
             * which consists of four decimal numbers, each ranging from 0 to 255, separated by dots, e.g., 172.16.254.1 . The generalized form of an
             * IPv4 address is (0-255).(0-255).(0-255).(0-255). Here we are considering numbers only from 0 to 255 and any additional leading zeroes
             * will be considered invalid.

             Your task is  to complete the function isValid which returns 1 if the ip address is valid else returns 0. 
             * The function takes a string ip as its only argument .*/

            Console.Write("Enter Ip Adress : ");

            string input = Console.ReadLine();

            char[] inputStr = input.ToCharArray();

            int j = 0;

            int result=0;

            int count = 0;

            for (int i = 0; i < inputStr.Count(); i++)
            { 
                if(inputStr[i]=='.')
                {
                    count++;
                }
            }


            if (count == 3)
            {

                for (int i = 0; i < inputStr.Count(); i++)
                {
                    if (j == 0 && inputStr[i] == '0')
                    {
                        result = 0;
                        break;
                    }
                    else if (Char.IsNumber(inputStr[i]))
                    {
                        result = 1;
                        j++;
                    }
                    else if (inputStr[i] == '.' && j==0)
                    {
                        result = 0;
                        break;
                    }

                    else if (inputStr[i] == '.')
                    {
                        j = 0;
                    }
                    else
                    {
                        break;
                    }

                }
            }

            else
            {
                result = 0;
            }


            if(result==0)
            {
                Console.WriteLine("Ip is Invalid");
            }
            else
            {
                Console.WriteLine("Ip is Valid");
            }

           
            Console.ReadKey();
           
        }
    }
}
