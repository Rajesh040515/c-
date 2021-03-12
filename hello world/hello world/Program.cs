using System;
using hello_world.Math;
namespace hello_world
{

    class Program
    {
        static void Main(string[] args)
        {
           var firstname = "rajesh";
            var lastname = "patel";
            var fullname = firstname + " " + lastname;
            Console.WriteLine(fullname);
            var myfullname = string.Format("my name is {0} {1}", firstname, lastname);

            var names = new string[2] { "a", "b" };
            var formatnames = string.Join(",", names);
            Console.WriteLine(formatnames);
        
        }
    }
}
