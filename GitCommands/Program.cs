using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.FileName = "git";
        startInfo.Arguments = "branch";
        startInfo.RedirectStandardOutput = true;

        using (Process process = new Process())
        {
            process.StartInfo = startInfo;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            System.Console.WriteLine(output);
        }
    }
}
