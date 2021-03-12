using System;
using hello_world.Math;
namespace hello_world
{
    public enum shippningmethod
    {

        regularmail=1,
        registermail=2,
        express=3

    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = shippingmethod.express;
            Console.WriteLine((int)method);
            var str = method.ToString();
            var methodname = "express";
            var shippingmethod=(shippingmethod)enum.Parse(typeof(shippningmethod),methodname);
        
        }
    }
}
