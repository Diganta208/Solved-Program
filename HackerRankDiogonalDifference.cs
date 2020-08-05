using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication41
{
    class Program
    {
        static void Main(string[] args)
        {


            int no = Convert.ToInt32(Console.ReadLine());
            int[,] input = new int[no, no];

            for (int i = 0; i < no; i++)
            {
                for (int j = 0; j < no; j++)
                {
                    input[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int firstDiogonal = 0;
            int secondDiogonal = 0;

            for (int i = 0; i < no; i++)
            {
                for (int j = 0; j < no; j++)
                {
                   if(i==j)
                   {
                       firstDiogonal = firstDiogonal + input[i,j];
                   }

                    if( j==no-i-1)
                    {
                        secondDiogonal = secondDiogonal + input[i, j];
                    }
                }
            }

            if(firstDiogonal>=secondDiogonal)
            {
                Console.WriteLine(firstDiogonal - secondDiogonal);
            }
            else
            {
                Console.WriteLine(secondDiogonal - firstDiogonal);
            }

            Console.ReadKey();
        }
    }
}
