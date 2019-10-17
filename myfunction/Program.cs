using System;

namespace myfunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! What's your name?");
            string usersName = Console.ReadLine();
            Console.WriteLine("What's your favorite color?");
            string userfavColor = Console.ReadLine();
            KnowMe(usersName, userfavColor);
        }
        public static void KnowMe (string name, string color)
        {
            Console.WriteLine($"Hello, {name}. Your favorite color is {color}. ");

        }
    }
}
