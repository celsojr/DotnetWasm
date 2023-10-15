namespace test;

public class PlaywrightTests
{
    [Fact]
    public async Task Full()
    {
#if DEBUG
        var headless = false;
        var slowMo = 250;
#else
        var headless = true;
        var slowMo = 0;
#endif

        var playwright = await Playwright.CreateAsync();
        var browser = await playwright.Chromium.LaunchAsync(new() { Headless = headless, SlowMo = slowMo });
        var page = await browser.NewPageAsync();
        var port = Environment.GetEnvironmentVariable("DOTNET_SERVE_PORT") ?? "5053";
        var homeUrl = $"http://127.0.0.1:{port}/index.html";

        await page.GotoAsync(homeUrl);

        // wait for the page load
        await Task.Delay(3000);

        var spanInnerText = await page.Locator("span").TextContentAsync();
        Assert.Equal($"Hello, World! Greetings from {homeUrl}", spanInnerText);
    }
}
