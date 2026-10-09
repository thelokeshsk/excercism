static class LogLine
{
    public static string INFO = "[INFO]:";
    public static string WARNING = "[WARNING]:";
    public static string ERROR = "[ERROR]:";

    public static (string logLevel, string message) Parse(string logLine) {
        if(logLine.StartsWith(INFO, StringComparison.Ordinal)){
            return ("info", logLine[INFO.Length..].Trim());
        }
        else if(logLine.StartsWith(WARNING,StringComparison.Ordinal)){
            return ("warning", logLine[WARNING.Length..].Trim());
        }
        else if(logLine.StartsWith(ERROR,StringComparison.Ordinal)){
            return ("error", logLine[ERROR.Length..].Trim());
        }
        else{
            return ("unknown", "unknown logLevel");
        }
    }
    
    public static string Message(string logLine)
    {
        return Parse(logLine).message;
    }

    public static string LogLevel(string logLine)
    {
        return Parse(logLine).logLevel;

    }

    public static string Reformat(string logLine)
    {
        var result = Parse(logLine);
        return $"{result.message} ({result.logLevel})";

    }
}
