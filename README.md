# BlazorDesktop-Template

Minimal cross-platform desktop starter using:

- .NET 10
- C#
- Blazor / Razor
- HTML / CSS
- PhotinoX.Blazor 5.2.2


## Requirements

- .NET 10 SDK
- Windows: WebView2 Runtime
- Linux: WebKitGTK 4.1
- macOS: WKWebView is provided by macOS

The included `global.json` accepts .NET 10 SDK 10.0.100 or any later
10.0 feature band installed on the machine.

## Run the starter directly

```powershell
dotnet restore
dotnet run
```

You should get a native desktop window containing a working Blazor button.

## Use as a local `dotnet new` template

From the repository root:

```powershell
dotnet new install .
```

Create a project:

```powershell
dotnet new photinox-blazor -n MyApp
cd MyApp
dotnet run
```

`DesktopApp` is the template's source name, so the .NET template engine
replaces it with the name supplied with `-n`.

To uninstall the local template later:

```powershell
dotnet new uninstall PhotinoX.Blazor.DotNet10.Template
```

If that exact uninstall identifier differs on your machine, run:

```powershell
dotnet new uninstall
```

to list installed custom templates and their uninstall commands.

