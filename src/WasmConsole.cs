namespace DotnetWasm;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public partial class ConsoleInterop
{
    public ConsoleInterop()
    {
    }

    [JSImport("globalThis.console.warn")]
    internal static partial void Warn([JSMarshalAs<JSType.String>] string message);

    [JSImport("globalThis.console.error")]
    internal static partial void Error([JSMarshalAs<JSType.String>] string message);

    private string? GetDebuggerDisplay()
    {
        return this.ToString();
    }
}
