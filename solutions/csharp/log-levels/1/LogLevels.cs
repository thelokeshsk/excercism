static class LogLine
{
    public static string INFO = "[INFO]:";
    public static string WARNING = "[WARNING]:";
    public static string ERROR = "[ERROR]:";
    
    public static string Message(string logLine)
    {
        string message = "";
        if(logLine.StartsWith(INFO)){
            message = logLine[7..];
            
        }
        else if(logLine.StartsWith(WARNING)){
            message = logLine[10..];
        } 
        else{
            message = logLine[8..];
        }
        
        message = message.TrimStart();
        return message.TrimEnd();
    }

    public static string LogLevel(string logLine)
    {
        if(logLine.StartsWith(INFO)){
            return "info";
        }
        if(logLine.StartsWith(WARNING)){
            return "warning";
        }
       
            return "error";

    }

    public static string Reformat(string logLine)
    {
        string message = "";
        if(logLine.StartsWith(INFO)){
            message = logLine[7..].TrimStart();
            message = message.TrimEnd();
            return $"{message} (info)";
        }
        if(logLine.StartsWith(WARNING)){
            message = logLine[10..].TrimStart();
            message = message.TrimEnd();
            return $"{message} (warning)";
        }
            message = logLine[8..].TrimStart();
            message = message.TrimEnd();
            return $"{message} (error)";

    }
}
