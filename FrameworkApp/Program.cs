using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interop;
using Library1;
using Library2;

namespace FrameworkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var test2 = Class2.Create();
            Console.WriteLine(Class1.Consume(test2));

            var test1 = Class1.Create();


            Console.WriteLine(Class2.Consume(test1));

            
            Console.WriteLine(test1.GetType() == test2.GetType());

            Console.WriteLine(test1.GetType().IsEquivalentTo(test2.GetType()));

        }
    }
}
