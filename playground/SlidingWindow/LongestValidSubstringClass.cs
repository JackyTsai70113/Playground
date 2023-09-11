namespace playground.SlidingWindow;

public class LongestValidSubstringClass
{
    /// <summary>
    /// https://leetcode.com/problems/length-of-the-longest-valid-substring
    /// </summary>
    public static int LongestValidSubstring(string word, IList<string> forbidden)
    {
        var set = new HashSet<string>(forbidden);
        int n = word.Length, res = 0;
        for (int left = 0, right = 0; right < word.Length; ++right)
        {
            for (int j = Math.Max(left, right - 10); j <= right; ++j)
            {
                if (set.Contains(word[j..(right + 1)]))
                    left = j + 1;
            }
            res = Math.Max(res, right - left + 1);
        }
        return res;
    }
}
