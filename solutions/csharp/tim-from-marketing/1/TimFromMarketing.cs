static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string ans = "";
        if(!(id is null)) ans += $"[{id}] - ";
        ans += name + " - ";
        if(!(department is null)) ans += $"{department.ToUpper()}";
        else ans += "OWNER";
        return ans;
    }
}
