Ben's Hidden Start
===

![price: free](https://img.shields.io/badge/price-free-brightgreen) [![Build](https://img.shields.io/github/actions/workflow/status/Aldaviva/bhstart/dotnetframework.yml?branch=master&logo=github)](https://github.com/Aldaviva/bhstart/actions/workflows/dotnetframework.yml)

*Start console programs without showing a visible command prompt window*

It is insane that [NTWind Software](https://www.ntwind.com/software/hstart.html) charges [20 American dollars](https://www.ntwind.com/software/hstart/register.html) to call [`Process.Start`](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.process.start). I'll do it for you for free.

## Requirements

- [.NET Framework 4.8 or later](https://dotnet.microsoft.com/download/dotnet-framework)

## Installation

1. Download `bhstart.exe` from the [latest release](https://github.com/Aldaviva/bhstart/releases/latest).

## Usage

```bat
bhstart.exe EXECUTABLE [ARGUMENT]...
```

### Example

```bat
bhstart.exe "C:\Program Files\Git\usr\bin\gpg-agent.exe" --daemon
```