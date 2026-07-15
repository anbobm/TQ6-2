using System;

public class ConsoleLogger : Logger
{
    public override void Log(string message)
    {
        Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss.ffffff} {message}");
    }
}