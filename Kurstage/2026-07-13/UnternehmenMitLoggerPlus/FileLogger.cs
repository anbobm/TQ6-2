public class FileLogger : ILogger
{
    public void Log(string message)
    {
        File.AppendAllText("protokoll.log", $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.ffffff} {message}\n");
    }
}