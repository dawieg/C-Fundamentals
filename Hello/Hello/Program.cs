using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Name?");
            string name = Console.ReadLine();

            Console.WriteLine("How many hours did you sleep last night <0-24>");
            int sleep = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Hello, " + name);

            if (sleep >= 8)
            {
                Console.WriteLine("You are well rested!!!");
            }
            else
            {
                Console.WriteLine("You need more rest!!!");
            }
        }
    }
}
