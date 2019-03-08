using System;
using Interop;

namespace Library2
{
    public static class Class2
    {
        public static ITest Create() => new Test2();

        public static string Consume(ITest test) => test.GetValue();
    }

    public class Test2 : ITest
    {
        public string GetValue()
        {
            return "Library2";
        }
    }
}
