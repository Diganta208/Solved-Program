using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication40
{
    class Program
    {
        static void Main(string[] args)
        {
            /*HackerLand National Bank has a simple policy for warning clients about possible fraudulent account activity. If the amount spent by a 
            * client on a particular day is greater than or equal to  the client's median spending for a trailing number of days, they send the 
            * client a notification about potential fraud. The bank doesn't send the client any notifications until they have at least that trailing 
            * number of prior days' transaction data.

          Given the number of trailing days  and a client's total daily expenditures for a period of  days, find and print the number of times the 
            * client will receive a notification over all  days.

         For example d=3,  and expendetures={10,20,30,40,50} . On the first three days, they just collect spending data. At day 4, we have trailing 
            * expenditures of [10,20,30] . The median is 20 and the day's expenditure is 40. Because 40>=20*2, there will be a notice. The next day,
            * our trailing expenditures are [20,30,40] and the expenditures are 50. This is less than 2*30 so no notice will be sent. Over the period,
            * 1 there was one notice sent.

            * 
           Note: The median of a list of numbers can be found by arranging all the numbers from smallest to greatest. If there is an odd number of 
            * numbers, the middle one is picked. If there is an even number of numbers, median is then defined to be the average of the two middle 
            * values.*/



            int n = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            Implement aImplement = new Implement();

            int[] arr = new int[n];

            for(int i=0; i<n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int m = 0;
            int notification = 0;

            for(int j=d; j<n-1; j++)
            {
                int[] newArr = new int[d];
                for(int i=j-1; i>=j-d; i--)
                {
                    newArr[m] = arr[i];
                    m++;
                }
               
                aImplement.Sort(newArr);
                int mean= aImplement.Mean(newArr);
                if (mean * 2 >= arr[j])
                {
                    notification = notification + 1;
                }

                m = 0;
            }

            Console.WriteLine(notification);
            Console.ReadKey();
        }
    }
}
