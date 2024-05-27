using System.Text;
using System.Runtime.InteropServices;

namespace DotnetWasm
{
    static unsafe class Extensions
    {
        internal static sbyte* ToSBytePtr(this string text)
        {
            // Calculate the array size
            Span<byte> utf8Bytes = stackalloc byte[Encoding.UTF8.GetByteCount(text)];

            // Convert string to byte array
            Encoding.UTF8.GetBytes(text, utf8Bytes);

            // Allocate memory for sbyte* array
            sbyte* sbytePtr = (sbyte*)Marshal.AllocHGlobal(utf8Bytes.Length);

            // Copy the byte array to the allocated memory
            for (int i = 0; i < utf8Bytes.Length; i++)
            {
                sbytePtr[i] = (sbyte)utf8Bytes[i];
            }

            return sbytePtr;
        }
    }
}
