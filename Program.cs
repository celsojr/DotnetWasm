using System;
using System.Runtime.InteropServices.JavaScript;

using static ConsoleInterop;
using static WindowInterop;

Console.WriteLine("Hello, Browser!");

public partial class Program
{
    [JSExport]
    internal static string Greeting()
    {
        string text = $"Hello, World! Greetings from {GetHRef()}";
        Console.WriteLine(text);
        Warn("This is a warn!");
        Alert("This is an alert!");
        return text;
    }
}
