using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
           /*Given length L and breadth B of N rectangles. The task is to return maximum area of the rectangle.*/


            int n = Convert.ToInt32(Console.ReadLine());
            int[] Length = new int[n * 2];

            for(int i=0; i<Length.Count(); i++)
            {
                Length[i] = Convert.ToInt32(Console.ReadLine());
            }

            int maxArea = 0;

            for(int i=0; i<Length.Count()-1; i++)
            {
                for(int j=i+1; j<Length.Count(); j++)
                {
                    int area = Length[i] * Length[j];
                    if(area>maxArea)
                    {
                        maxArea = area;
                    }
                }
            }

            Console.WriteLine(maxArea);
            Console.ReadKey();
        }
    }
}
