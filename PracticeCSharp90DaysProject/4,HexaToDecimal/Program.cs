using System;
using System.Globalization;

namespace _4_HexaToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            var hexval = Console.ReadLine();
            int decValue = int.Parse(hexval, NumberStyles.HexNumber);
            Console.WriteLine("Convert to-");
            Console.WriteLine("Decimal number: " + decValue);
        }
    }
}
