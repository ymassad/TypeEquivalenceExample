using System;
using System.Runtime.InteropServices;

[assembly:Guid("592C5AC0-9DC6-4AF4-9A35-B858668AD051")]
[assembly:PrimaryInteropAssembly(1,0)]

namespace Interop
{
    [Guid("8885C226-E8F8-4D81-8E18-DC1A8296A300")]
    [ComImport]
    public interface ITest
    {
        string GetValue();
    }
}
