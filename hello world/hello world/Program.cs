using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion

            /* byte b = 1;
             int i = b;
             Console.WriteLine(i);*/


            //explicit conversion
            /*int i = 1;
            byte b = (byte)i;
            Console.WriteLine(b);*/
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine(" ");
                
            }
          

        }
    }
}
