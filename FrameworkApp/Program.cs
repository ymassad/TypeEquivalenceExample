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

            var interface1Type = test1.GetType().GetInterfaces().Single();

            var interface2Type = test2.GetType().GetInterfaces().Single();

            Console.WriteLine(interface1Type == interface2Type);

            Console.WriteLine(interface1Type.IsEquivalentTo(interface2Type));

            List<ITest> list = new[] { test1, test2 }.ToList();
        }
    }
}
