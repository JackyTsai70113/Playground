namespace playground._3400_3499;

public class _3403_AnswerString
{
    public static string AnswerString(string word, int numFriends)
    {
        if (numFriends == 1) return word;
        int n = word.Length;
        var res = "";
        for (int i = 0; i < n; i++)
        {
            int len = Math.Min(word.Length - numFriends + 1, n - i);
            var cur = word.Substring(i, len);
            if (res.CompareTo(cur) < 0)
                res = cur;
        }
        return res;
    }
}
