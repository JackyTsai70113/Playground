namespace playground.LeetCode._1000_1999;

public class _1297__MaxFreq
{
    public static int MaxFreq(string s, int maxLetters, int minSize, int maxSize)
    {
        var d = new Dictionary<string, int>();
        var counts = new int[256];
        int count = 0;
        for (int l = 0, r = 0; r < s.Length; r++)
        {
            counts[s[r]]++;
            if (counts[s[r]] == 1)
                count++;
            while (count > maxLetters || r - l + 1 > minSize)
            {
                counts[s[l]]--;
                if (counts[s[l]] == 0)
                    count--;
                l++;
            }
            if (r - l + 1 == minSize)
            {
                var str = s[l..(r + 1)];
                d[str] = d.GetValueOrDefault(str) + 1;
            }
        }
        return !d.Any() ? 0 : d.Values.Max();
    }
}
