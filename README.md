## .NET WebAssembly Browser app

[![DotnetWasm CI](https://github.com/celsojr/DotnetWasm/actions/workflows/playwright.yml/badge.svg)](https://github.com/celsojr/DotnetWasm/actions/workflows/playwright.yml)

## Build

You can build the app from Visual Studio or from the command-line:

```
dotnet workload restore --skip-sign-check
dotnet build -c Debug/Release
```

After building the app, the result is in the `bin/$(Configuration)/net8.0/browser-wasm/AppBundle` directory.

## Run

You can build the app from Visual Studio or the command-line:

```
dotnet run -c Debug/Release
```

Or you can start any static file server from the AppBundle directory:

```
dotnet tool install dotnet-serve --global
dotnet serve -d:bin/$(Configuration)/net8.0/browser-wasm/AppBundle
```

## How to test with Playwright
In first console
```
dotnet run --project ./src/DotnetWasm.csproj
```
In second console
```
dotnet build test/PlaywrightTests.csproj
pwsh test/bin/$(Configuration)/net7.0/playwright.ps1 install
dotnet test test/PlaywrightTests.csproj
```
