static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string ans = "";
        if(!(id is null)) ans += $"[{id}] - ";
        ans += name + " - ";
        ans += department?.ToUpper() ?? "OWNER";
        return ans;
    }
}
