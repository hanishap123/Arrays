// Author: Hanisha Pagarani
// Date: 02/04/2021
// Comments: This C# console application code demonstrates the use of arrays with no input from the user

using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // No input from user
            // This is a manually populated array, iterated with a foreach loop
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Press any key to exit the program...");
            // Pause the program and await the user to press a key to end the program
            Console.ReadKey(true);
        }
    }
}
