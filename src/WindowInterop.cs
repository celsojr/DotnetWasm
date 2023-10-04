namespace DotnetWasm;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public partial class WindowInterop
{
    public WindowInterop()
    {
    }

    // This does not work with globalThis because this is not a function
    /// <summary>
    /// The href property of the Location interface is a stringifier that
    /// returns a string containing the whole URL, and allows the href to be updated.
    /// </summary>
    [JSImport("window.location.href", "main.js")]
    internal static partial string GetHRef();

    // Functions accessible on the global namespace can be imported by using
    // the globalThis prefix in the function name and by using the [JSImport]
    // attribute without providing a module name.
    /// <summary>
    /// window.alert() instructs the browser to display a dialog
    /// with an optional message, and to wait until the user dismiss
    /// </summary>
    /// <param name="message">A string you want to display in the alert dialog</param>
    [JSImport("globalThis.window.alert")]
    internal static partial void Alert(string message);

    private string? GetDebuggerDisplay()
    {
        return this.ToString();
    }
}
