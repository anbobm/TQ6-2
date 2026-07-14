using System;
using System.IO;

public class FileLogger : ILogger
{
    public void Log(string message)
    {
        File.AppendAllText("protokoll.log", $"{DateTime.Now}: {message}\n");
    }
}