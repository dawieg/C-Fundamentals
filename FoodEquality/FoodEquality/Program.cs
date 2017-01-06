using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            Food banana = new Food ("banana");
            Food banana2 = new Food("banana");
            Food chocolate = new Food("chocolate");

            Console.WriteLine("object banana = " + banana);
            Console.WriteLine("object banana2 = " + banana2);
            Console.WriteLine("object chocolate = " + chocolate);
            
            Console.WriteLine(banana.Equals(chocolate));
            Console.WriteLine(banana.Equals(banana2));
            Console.WriteLine(banana.Equals(null));
            
        }

    }
}
