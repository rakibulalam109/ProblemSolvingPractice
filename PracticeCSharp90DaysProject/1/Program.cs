using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = Convert.ToDouble(Console.ReadLine());
            double b = Math.Floor(Math.Log10(input) + 1);
            
            int c = Convert.ToInt32(b);

            c = c - 1;

            while (input > 0)
            {

                var result = input / (Math.Pow(10, c));
                input = input % (Math.Pow(10, c));
                c = c - 1;

                Console.Write($"{Math.Floor(result)} ");
                if (c + 1 >= 1)
                {
                    Console.Write($", ");
                }

            }
        }
    }
}
