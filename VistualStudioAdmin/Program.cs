using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string visualStudioPath = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Visual Studio 2022.lnk";
        
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = visualStudioPath,
            UseShellExecute = true,
            Verb = "runas"
        };
        
        try
        {
            Process.Start(startInfo);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
