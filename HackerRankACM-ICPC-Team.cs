using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication49
{
    class Program
    {
        static void Main(string[] args)
        {

            /*There are a number of people who will be attending ACM-ICPC World Finals. Each of them may be well versed in a
             * number of topics. Given a list of topics known by each attendee, you must determine the maximum number of topics 
             * a 2-person team can know. Also find out how many ways a team can be formed to know that many topics. Lists will
             * be in the form of bit strings, where each string represents an attendee and each position in that string represents
             * a field of knowledge, 1 if its a known field or 0 if not.*/



            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[m, n];

            Console.WriteLine("Plz enter 0 or 1 as input");

            for(int i=0; i<m; i++)
            {

                int p = 1 + i;
                Console.WriteLine("Plz enter data of "+ p +" :");

                for(int j=0; j<n; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int max = 0;
            int count = 0;
            int no = 0;

            
            for(int i=0; i<m-1; i++)
            {

                 for(int j=i+1; j<m; j++)
                 {
                     for(int k=0; k<n; k++)
                     {
                         if(arr[i,k]==1 ||arr[j,k]==1)
                         {
                             no = no + 1;
                         }
                     }

                     if(no>max)
                     {
                         max = no;
                         count = 1;
                         no = 0;
                     }
                     else if(no==max)
                     {
                         count++;
                         no = 0;
                     }
                     else
                     {
                         no = 0;
                     }
                 }

            }


            Console.WriteLine("The maximum number of topics is : " + count);
            Console.WriteLine("Number of ways to form a 2-person team that knows the maximum number of topics is : "+ max);
            Console.ReadKey();
        }
    }
}
