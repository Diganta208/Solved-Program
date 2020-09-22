using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication56
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Size of Array");

            int i = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[i];
            
            Console.WriteLine("Please Enter Value array");

            for (int m = 0; m < i; m++)
            {
               
                    arr[m] = Convert.ToInt32(Console.ReadLine());
                
            }

          

            int rightHandSide = 0;
            int leftHandSide = 0;
            string status= "Not found";


            if(i==1)
            {
                Console.WriteLine("Equlubriam is:" + arr[i-1]);
            }
            else if(i==2)
            {
                Console.WriteLine("Equlubriam not present");
            }
            else
            {
                for (int m = 0; m < i; m++)
                {
                    int check = arr[m];
                    for(int p=0; p<m; p++)
                    {
                        leftHandSide = leftHandSide + arr[p];
                    }
                    for(int q=m+1; q<i; q++)
                    {
                        rightHandSide = rightHandSide + arr[q];
                    }
                    if(leftHandSide==rightHandSide)
                    {
                        Console.WriteLine("Equlubriam is : " + check);
                        status = "Found";
                        break;
                    }
                    else
                    {
                        rightHandSide = 0;
                        leftHandSide = 0;
                    }
                }

                if(status == "Not found")
                {
                    Console.WriteLine("Equlubriam not present");
                }
            }

            

       
            Console.ReadKey();

        }
    }
}
