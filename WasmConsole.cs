using System.Diagnostics;
using System.Runtime.InteropServices.JavaScript;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public partial class ConsoleInterop
{
    private const string _mainJs = "main.js";

    public ConsoleInterop()
    {
    }

    [JSImport("console.warn", _mainJs)]
    internal static partial void Warn(string message);

    [JSImport("console.error", _mainJs)]
    internal static partial void Error(string message);

    private string GetDebuggerDisplay()
    {
        return this.ToString();
    }
}
