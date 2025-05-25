namespace playground.LeetCode._2000_2999;

public class _2131_LongestPalindrome
{
    public static int LongestPalindrome(string[] words)
    {
        var seen = new int[26, 26];
        int res = 0;
        foreach (var w in words)
        {
            var first = w[0] - 'a';
            var second = w[1] - 'a';
            if (seen[second, first] > 0)
            {
                seen[second, first]--;
                res += 4;
            }
            else
            {
                seen[first, second]++;
            }
        }

        for (int i = 0; i < 26; i++)
        {
            if (seen[i, i] > 0)
            {
                res += 2;
                break;
            }
        }
        return res;
    }
}
