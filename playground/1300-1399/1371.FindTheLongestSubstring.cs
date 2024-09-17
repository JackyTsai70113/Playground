namespace playground;

public class FindTheLongestSubstring1371
{
    public static int FindTheLongestSubstring(string s)
    {
        var d = new Dictionary<int, int> { [0] = -1 };
        int mask = 0, res = 0;
        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case 'a':
                    mask ^= 1;
                    break;
                case 'e':
                    mask ^= 2;
                    break;
                case 'i':
                    mask ^= 4;
                    break;
                case 'o':
                    mask ^= 8;
                    break;
                case 'u':
                    mask ^= 16;
                    break;
            }
            if (d.ContainsKey(mask))
                res = Math.Max(res, i - d[mask]);
            else
                d[mask] = i;
        }
        return res;
    }
}
