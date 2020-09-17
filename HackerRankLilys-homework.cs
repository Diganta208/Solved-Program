using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication53
{
    class Program
    {
        static void Main(string[] args)
        {
      //Whenever George asks Lily to hang out, she's busy doing homework. George wants to help her finish it faster, but he's in over his head! Can you help George understand Lily's homework so she can hang out with him?/
            int no = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[no];
            for(int i=0; i<no; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }


            int Count = 0;
            int min = 100000;

            for(int i =0; i <no-1; i++)
            {
                int index=0;
                int check = arr[i];
                for(int j=i+1; j<no; j++)
                {
                    if(arr[j]< min)
                    {
                        min = arr[j];
                        index = j;
                    }
                }
                if(check>min)
                {
                    Count++;
                   
                    arr[i] = min;
                    arr[index] = check;

                }

                min = 100000;
            }


            Console.WriteLine(Count);
            Console.ReadKey();
        }
    }
}
