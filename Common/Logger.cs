using System.IO;

namespace PikatangScript.Common;

public static class Logger
{
    private static readonly string LogPath = Path.Combine(
        AppDomain.CurrentDomain.BaseDirectory, "logs");

    static Logger()
    {
        if (!Directory.Exists(LogPath))
        {
            Directory.CreateDirectory(LogPath);
        }
    }

    public static void Info(string message) => Log("INFO", message);
    public static void Warn(string message) => Log("WARN", message);
    public static void Error(string message, Exception? ex = null)
    {
        var msg = ex != null ? $"{message}\n{ex}" : message;
        Log("ERROR", msg);
    }

    private static void Log(string level, string message)
    {
        var timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
        var logLine = $"[{timestamp}] [{level}] {message}";
        Console.WriteLine(logLine);

        try
        {
            var fileName = Path.Combine(LogPath, $"app_{DateTime.Now:yyyyMMdd}.log");
            File.AppendAllText(fileName, logLine + Environment.NewLine);
        }
        catch
        {
        }
    }
}
