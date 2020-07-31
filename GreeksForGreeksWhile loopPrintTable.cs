using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication37
{
    class Program
    {
        static void Main(string[] args)
        {
            int no = Convert.ToInt32(Console.ReadLine());

            int i=10;
             while(i>0)
             {
                 Console.Write(no * i +" ");
                 i--;

             }
             Console.ReadKey();
        }
    }
}
