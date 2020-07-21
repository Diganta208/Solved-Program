using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int input = Convert.ToInt32(str);
            int[] arr= new int[str.Count()];
            int ab=input;

            int count=arr.Count()-1;
            while(ab % 10  > 0 )
            {
                arr[count] = ab % 10;
                ab = ab / 10;
                count--;
            }

            int result = 1;

            for(int i=0; i<arr.Count()-1; i++)
            {
                string st = arr[i].ToString() + arr[i + 1].ToString();
                int d = Convert.ToInt32(st);
                if(d<=26)
                {
                    result++;
                }
            }

            Console.WriteLine(result);
            Console.ReadKey();

           
        }
    }
}
