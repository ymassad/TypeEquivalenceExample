using System;
using System.Runtime.InteropServices;

[assembly: Guid("AC595CDF-37B0-459F-88A7-719A97D2CDC8")]
[assembly: PrimaryInteropAssembly(1, 0)]

namespace Interop
{
    [Guid("8885C226-E8F8-4D81-8E18-DC1A8296A300")]
    [ComImport]
    public interface ITest
    {
        string GetValue();
    }
}
