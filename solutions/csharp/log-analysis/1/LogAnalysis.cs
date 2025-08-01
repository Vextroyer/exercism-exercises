public static class LogAnalysis 
{
    public static string SubstringAfter(this string str,string delimiter) => str[(str.IndexOf(delimiter) + delimiter.Length) ..];

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str,string after,string before){
        string tmp = str.SubstringAfter(after);
        return tmp[..tmp.IndexOf(before)];
    }
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string logLine) => logLine.SubstringAfter(": ");

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string logLine) => logLine.SubstringBetween("[","]");
}