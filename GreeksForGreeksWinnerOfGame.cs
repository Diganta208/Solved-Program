using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {

            int stones = Convert.ToInt32(Console.ReadLine());

            if(stones%2==0)
            {
                Console.WriteLine("Player B");
            }
            else
            {
                Console.WriteLine("Player A");
            }
        }
    }
}
