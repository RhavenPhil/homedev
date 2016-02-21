using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExecuteCommandLineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // The /C is important to get the command to execute.

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/C tree /f ""E:\RIP Output"" > ""C:\Temp\Result.txt""";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
            Console.Out.Write("Exit Code = " + process.ExitCode);
        }
    }
}
