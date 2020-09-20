using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication55
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No element of orginal array :");
           int no=Convert.ToInt32( Console.ReadLine());
           int[] Orginalarray = new int[no];
           Console.WriteLine("Values of orginal array :");

            for(int i=0; i<no; i++)
            {
                Orginalarray[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("No element of Another array :");
            int ex = Convert.ToInt32(Console.ReadLine());
            int[] Anotherarray = new int[ex];
            Console.WriteLine("Values of Another array :");

            for (int i = 0; i < ex; i++)
            {
                Anotherarray[i] = Convert.ToInt32(Console.ReadLine());

            }
            List<int> chacked = new List<int>();
            List<int> result = new List<int>();

            int countOrginal = 1;
            int countAnother = 0;


            for(int i=0; i<no; i++)
            {
               if(!chacked.Contains( Orginalarray[i]))
               {
                   for(int j=i+1; j<no; j++)
                   {
                       if (Orginalarray[i] == Orginalarray[j])
                       {
                           countOrginal++;
                       }

                   }

                   for(int m=0; m<ex; m++)
                   {
                       if (Orginalarray[i] == Anotherarray[m])
                       {
                           countAnother++;
                       }
                   }
                   int dif = countOrginal - countAnother;

                   if (dif > 0)
                   {
                       for (int p = 0; p<=dif - 1; p++)
                       {
                           result.Add(Orginalarray[i]);
                       }
                   }

                   countOrginal = 1;
                   countAnother = 0;
               }
            }

            Console.WriteLine("Missing values are:");

            for(int i=0; i<result.Count(); i++)
            {
                Console.WriteLine(result[i]);
            }

            Console.ReadKey();


        }
    }
}
