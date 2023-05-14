namespace playground.Greedy;

public class KSimilarityClass
{
    /// <remarks>https://leetcode.com/problems/k-similar-strings</remarks>
    public static int KSimilarity(string s1, string s2)
    {
        var q = new Queue<(string s, int d)>();
        q.Enqueue((s1, 0));
        var seen = new HashSet<string> { s1 };
        while (q.Count > 0)
        {
            var (s, d) = q.Dequeue();
            if (s == s2) return d;
            int i = 0;
            while (s[i] == s2[i]) i++;
            for (int j = i + 1; j < s.Length; ++j)
            {
                if (s[j] == s2[j] || s[j] != s2[i]) continue;
                var newStr = s[..i] + s[j] + s[(i + 1)..j] + s[i] + s[(j + 1)..];
                if (seen.Add(newStr)) q.Enqueue((newStr, d + 1));
            }
        }
        return -1;
    }
}
