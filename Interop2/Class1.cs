using System;
using System.Runtime.InteropServices;

[assembly: Guid("0989C5EE-FD13-4D31-8DD6-CBDEAC456A35")]
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
