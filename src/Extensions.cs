using System.Text;

namespace DotnetWasm
{
    static unsafe class Extensions
    {
        internal static sbyte* ToSBytePtr(this string text)
        {
            // Convert string to byte array
            ReadOnlySpan<byte> byteArray = Encoding.UTF8.GetBytes(text);

            // Allocate memory for sbyte* array
            sbyte* sbytePtr = (sbyte*)System.Runtime.InteropServices.Marshal.AllocHGlobal(byteArray.Length);

            // Copy the byte array to the allocated memory
            for (int i = 0; i < byteArray.Length; i++)
            {
                sbytePtr[i] = (sbyte)byteArray[i];
            }

            return sbytePtr;
        }
    }
}
