namespace playground;

public class CountCompleteSubstrings_2953
{
    /// <summary>
    /// https://leetcode.com/problems/count-complete-substrings
    /// </summary>
    public static int CountCompleteSubstrings(string s, int k)
    {
        int n = s.Length, res = 0;
        var counts = new int[n + 1][];
        counts[0] = new int[26];
        for (int i = 0; i < n; ++i)
        {
            counts[i + 1] = counts[i].ToArray();
            counts[i + 1][s[i] - 'a']++;
        }
        for (int l = 0, r = 0; r < n; r++)
        {
            if (r > 0 && Math.Abs(s[r - 1] - s[r]) > 2)
            {
                l = r;
            }
            for (int uniqueCharsCount = 1; uniqueCharsCount <= 26; ++uniqueCharsCount)
            {
                int length = uniqueCharsCount * k;
                int startIndex = r - length + 1;
                if (startIndex < l) break;
                bool ok = true;
                for (int checkChar = 0; checkChar < 26; checkChar++)
                {
                    int diff = counts[r + 1][checkChar] - counts[startIndex][checkChar];
                    if (diff != 0 && diff != k)
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok) res++;
            }
        }
        return res;
    }
}
