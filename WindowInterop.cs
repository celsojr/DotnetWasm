using System.Diagnostics;
using System.Runtime.InteropServices.JavaScript;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public partial class WindowInterop
{
    private const string _mainJs = "main.js";

    public WindowInterop()
    {
    }

    [JSImport("window.location.href", _mainJs)]
    internal static partial string GetHRef();

    [JSImport("window.alert", _mainJs)]
    internal static partial void Alert(string message);

    private string GetDebuggerDisplay()
    {
        return this.ToString();
    }
}
