namespace playground;

public class MinAnagramLength3138
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-length-of-anagram-concatenation
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static int MinAnagramLength(string s)
    {
        for (int len = 1; len <= s.Length / 2; len++)
        {
            if (s.Length % len != 0) continue;
            var chs = new int[26];
            for (int i = 0; i < len; i++)
            {
                chs[s[i] - 'a']++;
            }
            var b = true;
            for (int i = len; i < s.Length; i += len)
            {
                var chs2 = new int[26];
                for (int j = i; j < i + len; j++)
                {
                    chs2[s[j] - 'a']++;
                }
                for (int j = 0; j < 26; j++)
                {
                    if (chs[j] != chs2[j])
                    {
                        b = false;
                        break;
                    }
                }
                if (b == false)
                {
                    break;
                }
            }
            if (b) return len;
        }
        return s.Length;
    }
}
