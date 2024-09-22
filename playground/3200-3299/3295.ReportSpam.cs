namespace playground;

public class ReportSpam3295
{
    public static bool ReportSpam(string[] message, string[] bannedWords)
    {
        var count = 0;
        var set = bannedWords.ToHashSet();
        foreach (var m in message)
        {
            if (set.Contains(m))
            {
                count++;
                if (count == 2)
                    return true;
            }
        }
        return false;
    }
}
