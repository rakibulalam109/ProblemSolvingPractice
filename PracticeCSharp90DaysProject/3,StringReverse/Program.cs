using System;

namespace _3_StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a C# program to reverse the words of a sentence.
            //Sample Output:
            //Original String: Display the pattern like pyramid using the alphabet.
            //Reverse String: alphabet.the using pyramid like pattern the Display
            var input = Console.ReadLine().Split(' ');
       
            Array.Reverse(input);
            
            foreach (var item in input)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
