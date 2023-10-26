using System.Text;

namespace DotnetWasm
{
    static unsafe class Helper
    {
        // This cannot be an extension method because the first
        // parameter of an extension method cannot be a sbyte*
        internal static string SBytePtrToString(sbyte* arr)
        {
            // Calculate the length of the sbyte* array
            int length = 0;
            while (arr[length] != 0)
            {
                length++;
            }

            // Convert sbyte* array to ReadOnlySpan<byte>
            ReadOnlySpan<byte> byteSpan = new ReadOnlySpan<byte>(arr, length);

            // Use Encoding to convert byte array to string
            string result = Encoding.UTF8.GetString(byteSpan);

            return result;
        }

        internal static unsafe void FreeSbytePtr(sbyte* sbytePtr)
        {
            // Free the allocated memory
            System.Runtime.InteropServices.Marshal.FreeHGlobal((IntPtr)sbytePtr);
        }
    }
}
