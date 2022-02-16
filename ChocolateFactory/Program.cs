using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChocolateLibrary;

namespace ChocolateFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler newBoiler = ChocolateBoiler.getInstance();

            Console.WriteLine(newBoiler.Display());
            Console.WriteLine(newBoiler.Fill());
            Console.WriteLine(newBoiler.Boil());
            Console.WriteLine(newBoiler.Drain());

            Console.ReadKey();
        }
    }
}
