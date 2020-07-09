using System;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {

            int product1 = Convert.ToInt32(Console.ReadLine());
            int amountOfProduct1 = Convert.ToInt32(Console.ReadLine());
            double priceOfProduct1 = Convert.ToDouble(Console.ReadLine());

            int product2 = Convert.ToInt32(Console.ReadLine());
            int amountOfProduct2 = Convert.ToInt32(Console.ReadLine());
            double priceOfProduct2 = Convert.ToDouble(Console.ReadLine());

            double pay = (amountOfProduct1 * priceOfProduct1) + (amountOfProduct2 * priceOfProduct2);
            Console.WriteLine("VALOR A PAGAR: R$ " + String.Format("{0:0.00}", pay));
            Console.ReadKey();

        }
    }
}
