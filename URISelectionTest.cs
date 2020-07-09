using System;


namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {

            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            int D = Convert.ToInt32(Console.ReadLine());

            if (B > C && D > A && (C + D) > (A + B) && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }

            Console.ReadKey();

        }
    }
}
