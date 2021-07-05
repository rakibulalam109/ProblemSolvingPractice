using System;
using System.Globalization;

namespace _3day._2code_HexaToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to convert a hexadecimal number to decimal number.
            //E7A9 = 14×16^3 + 7×16^2 + 10×16^1 + 9×16^0 = 57344 + 1792 + 160 + 9 = 59305

            var hexval = Console.ReadLine();
            int decValue = int.Parse(hexval, NumberStyles.HexNumber);
            Console.WriteLine("Convert to-");
            Console.WriteLine("Decimal number: " + decValue);
        }
    }
}
