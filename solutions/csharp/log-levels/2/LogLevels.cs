static class LogLine
{
    private static (string level,string message) Partition(string logLine){
        string[] parts = logLine.Split(':',2);
        parts[0] = parts[0].Trim([' ','[',']']).ToLower();
        parts[1]=parts[1].Trim();
        return (parts[0],parts[1]);
    }
    public static string Message(string logLine) => Partition(logLine).message;

    public static string LogLevel(string logLine)=>Partition(logLine).level;

    public static string Reformat(string logLine)
    {
        var(level,message)=Partition(logLine);
        return $"{message} ({level})";
    }
}
