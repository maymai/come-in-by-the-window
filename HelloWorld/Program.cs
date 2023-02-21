using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what's your name?");
            var userName = "";
            userName = Console.ReadLine();
            Console.WriteLine("Hello, "+userName+". Nice to meet you.");
        }
    }
}
