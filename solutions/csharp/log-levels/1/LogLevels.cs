static class LogLine
{
    public static string Message(string logLine)
    {
        int ind = logLine.IndexOf(": ");
        return logLine.Substring(ind + 2).Trim();
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
        
    }
    public static string LogLevel(string logLine)
    {
        int start = logLine.IndexOf("[")+1;
        int end= logLine.IndexOf("]");
        return logLine.Substring(start, end-1).ToLower();
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
