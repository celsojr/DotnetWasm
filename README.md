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

## Run Raylib games
Installing the wasm tools for net7.0
```
dotnet workload restore --skip-sign-check
```
Publish the `Solution` from the root of the repository. Don't even try to use just build, [it's buggy](https://github.com/disketteman/DotnetRaylibWasm/issues/7#issuecomment-1356442508). Note the publishing takes a while.
Also, it might be necessary to remove the `bin` and `obj` folders in case your're facing unknown errors.
```
dotnet publish -c Release
```
Serve the `AppBundle` folder and it might be necessary to specify the supported mime types. If you see some errors in the browser console on the first run, try refreshing and they should go away.
```
dotnet serve --mime .wasm=application/wasm --mime .js=text/javascript --mime .json=application/json --directory bin\Release\net7.0\browser-wasm\AppBundle\
```

## How to test with Playwright (Do not apply for Raylib branch)
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
