using System;
using Interop;

namespace Library1
{
    public static class Class1
    {
        public static ITest Create() => new Test1();

        public static string Consume(ITest test) => test.GetValue();
    }

    public class Test1 : ITest
    {
        public string GetValue()
        {
            return "Library1";
        }
    }
}
