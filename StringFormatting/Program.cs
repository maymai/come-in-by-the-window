using System;

namespace StringFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            string apples = "Apples";
            int appleQuantity = 8;
            int applePrice = 100;
            string oranges = "Oranges";
            int orangeQuantity = 12;
            int orangePrice = 80;

            string column1Heading = "Fruit";
            string column2Heading = "Quantity";
            string column3Heading = "Price";

            //Adding a value to your variable on the string interpolation will align them. Positive values align to the right, negative values align to the left.
            Console.WriteLine($"{column1Heading,-12} {column2Heading,-8} {column3Heading,-7}");
            Console.WriteLine($"{apples,-12} {appleQuantity,-8} {applePrice / 100.0,-7:C}");
            Console.WriteLine($"{oranges,-12} {orangeQuantity,-8} {orangePrice / 100.0,-7:C}");

            //Adding :FX to the variable adds decimal points to the number format.
            Console.WriteLine($"PI in {Math.PI}");
            Console.WriteLine($"PI in {Math.PI:F3}");
            Console.WriteLine($"PI in {Math.PI:F0}");
            Console.WriteLine($"PI in {Math.PI:F12}");
            Console.WriteLine($"PI in {Math.PI:F99}");
        }
    }
}
