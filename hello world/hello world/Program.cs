using System;
using hello_world.Math;
namespace hello_world
{

    class Program
    {
        static void Main(string[] args)
        {
            var number = new int[3];
            number[0] = 1;

            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]);
            Console.WriteLine(number[2]);

            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);
        
            
            var str = new string[2] { "rajesh", "patel" };
            Console.WriteLine(str[0]);
        
        
        }
    }
}
