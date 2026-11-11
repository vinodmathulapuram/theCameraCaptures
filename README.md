# The Camera Captures — Blazor WebAssembly portfolio

Photography portfolio by Vinod updated.

A creative, responsive multi-page photography portfolio built with .NET 10 Blazor WebAssembly.

## Requirements
- .NET 10 SDK
- A terminal (zsh on macOS works)
- Optional: Visual Studio Code

## Run locally
From this folder:

```bash
dotnet --version
dotnet restore
dotnet run
```

Open the localhost URL printed by the CLI.

If you don't have a project file yet, create the Blazor WebAssembly starter first, then copy these files into it:

```bash
dotnet new blazorwasm -n TheCameraCaptures
cd TheCameraCaptures
```

The standard `blazorwasm` template can vary by SDK version. If `dotnet new blazorwasm` is unavailable, install the .NET 10 SDK from https://dotnet.microsoft.com/download/dotnet/10.0 and check templates with `dotnet new list blazor`.

## Important integration notes
- These pages assume the standard Blazor WebAssembly standalone template.
- Merge the `Router` setup in `App.razor` with the template's existing `App.razor` if needed.
- Replace the sample Unsplash image URLs in `Models/Photo.cs` with your own optimized `.webp` or `.jpg` images under `wwwroot/images/`.
- The contact form is a front-end demo only. It validates input but does not send email until you connect a backend or form service.
