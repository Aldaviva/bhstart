#nullable enable

using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BHStart;

internal static class MainClass {

    private static int Main(string[] args) {
        if (!args.Any()) {
            string selfExecutable = Assembly.GetExecutingAssembly().GetName().Name;
            MessageBox.Show($"""
                 {selfExecutable} EXECUTABLE [ARGUMENT]...
                 
                 Example:
                 {selfExecutable} "C:\Program Files\Git\usr\bin\gpg-agent.exe" --daemon
                 """,
                "Ben's Hidden Start usage", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 0;
        }

        string executable = args[0];
        string arguments  = CommandLine.Serializer.argvToCommandLine(args.Skip(1));

        ProcessStartInfo startInfo = new() {
            FileName               = executable,
            Arguments              = arguments,
            CreateNoWindow         = true,
            UseShellExecute        = false,
            RedirectStandardOutput = true,
            RedirectStandardError  = true,
            RedirectStandardInput  = true
        };

        try {
            using Process? process = Process.Start(startInfo);
        } catch (Exception e) {
            MessageBox.Show($"Failed to start {executable} {arguments}: " + e.Message, "Ben's Hidden Start", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 1;
        }

        return 0;
    }

}