using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
          //Paramaters (year, month, day, hour, minute, second)
          var date01 = new DateTime(2023, 11, 11, 20, 10, 00);
          var date02 = DateTime.UtcNow;
          var date03 = DateTime.Today;
          var date04 = DateTime.Now;

            Console.WriteLine(date01);
            Console.WriteLine(date02);
            Console.WriteLine(date03);
            Console.WriteLine(date04);
            
            // Keep the console window open
            Console.ReadLine();
        }
    }
}