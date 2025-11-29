# Blazor Auto Global Mode with Bootstrap Starter Template

A production-ready Blazor template with Bootstrap that uses auto global render mode, perfect for building modern web applications.

## Features

- ? Blazor WebAssembly + Server (Auto Global Render Mode)
- ? Bootstrap integration
- ? .NET 8, 9, and 10 support
- ? Clean project structure with Host and Client projects

## Installation

```bash
dotnet new install BlazorBootStrap.StarterTemplate
```

## Usage

Create a new project:

```bash
dotnet new blazor-bootstrap-auto-global -n MyBlazorApp
```

With specific framework:

```bash
dotnet new blazor-bootstrap-auto-global -n MyBlazorApp --Framework net10.0
```

## Parameters

| Parameter | Description | Default |
|-----------|-------------|---------|
| `--Framework` | Target framework (net8.0, net9.0, net10.0) | net10.0 |

## Getting Started

After creating your project:

```bash
cd MyBlazorApp
dotnet restore
dotnet run --project MyBlazorApp.Host
```

## Uninstall

```bash
dotnet new uninstall BlazorBootStrap.StarterTemplate
```

## License

MIT

## Support

For issues and questions, please visit: [GitHub Repository URL]
