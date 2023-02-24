Ben's Hidden Start
===

[![Build](https://img.shields.io/github/actions/workflow/status/Aldaviva/bhstart/dotnetframework.yml?branch=master&logo=github)](https://github.com/Aldaviva/bhstart/actions/workflows/dotnetframework.yml)

*Start console programs without showing a visible command prompt window*

It is insane that NTWind Software charges 20 American dollars to call `Process.StartNew`.

## Requirements

- .NET Framework 4.8 or later

## Installation

1. Download `bhstart.exe` from the [latest release](https://github.com/Aldaviva/bhstart/releases/latest)

## Usage

```bat
bhstart.exe EXECUTABLE [ARGUMENT]...
```

### Example

```bat
bhstart.exe "C:\Program Files\Git\usr\bin\gpg-agent.exe" --daemon
```