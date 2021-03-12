using System;
using hello_world.Math;
namespace hello_world
{

    class Program
    {
        static void Main(string[] args)
        {
            var r = new person();
            r.firstname = "Rajesh";
            r.lastname = "patel";
            r.introduce();
            calculator calculator = new calculator();
            var result = calculator.add(1, 2);
            System.Console.WriteLine(result);
        }
    }
}
