using System.Diagnostics;
public class Program
{
    public static void Main()
    {
        Process.Start("cmd.exe", "/c dir C:\\");
    }
}

