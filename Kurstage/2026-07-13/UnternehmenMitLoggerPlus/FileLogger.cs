using System;
using System.IO;

public class FileLogger : Logger
{
    public override void Log(string message)
    {
        File.AppendAllText("protokoll.log", $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.ffffff} {message}\n");
    }
}