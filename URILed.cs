using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {
            /*John wants to set up a panel containing different numbers of LEDs. He does not have many leds, he is not sure
             * if he will be able to mount the desired number. Considering the configuration of the LEDs of the numbers below,
             * make an algorithm that helps John to discover the number of LEDs needed to set the value.*/



            int no= Convert.ToInt32(Console.ReadLine());

            for (int m = 0; m < no; m++)
            {
                string input = Console.ReadLine();
                char[] inputStr = input.ToCharArray();
                int inputInt = Convert.ToInt32(input);
                int[] inputArr = new int[inputStr.Count()];



                int result = 0;
                int Number = inputInt;

                int j = inputStr.Count() - 1;
                int local;
                while (Number > 0)
                {
                    local = Number % 10;
                    Number = Number / 10;
                    inputArr[j] = local;
                    j--;

                }

                for (int i = 0; i < inputArr.Count(); i++)
                {
                    result = result + inputArr[i];
                }

                if (inputStr.Count() <= 5)
                {

                    result = result + inputStr.Count();
                    Console.WriteLine(result + " Leds");
                }
                else
                {
                    if (inputStr.Count() % 2 == 0)
                    {
                        result = result + (inputStr.Count() + no);
                        Console.WriteLine(result + " Leds");
                    }
                    else
                    {
                        result = result + (inputStr.Count() - no);
                        Console.WriteLine(result + " Leds");
                    }

                }
            }
            Console.ReadKey();
        }
    }
}
