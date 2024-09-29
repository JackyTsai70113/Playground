namespace playground._3300_3399;

public class _3306_CountOfSubstrings
{
    public static long CountOfSubstrings(string word, int k)
    {
        return AtMost(word, k) - AtMost(word, k + 1);
    }

    private static long AtMost(string word, int k)
    {
        var d = new Dictionary<char, int>
        {
            ['a'] = 0,
            ['e'] = 0,
            ['i'] = 0,
            ['o'] = 0,
            ['u'] = 0,
        };
        int ccount = 0;
        bool Valid()
        {
            return d.Values.All(x => x > 0) && ccount >= k;
        }
        long res = 0;
        for (int l = 0, r = 0; r < word.Length; r++)
        {
            if (d.ContainsKey(word[r]))
            {
                d[word[r]]++;
            }
            else
            {
                ccount++;
            }
            // update state by A[r]
            while (Valid())
            {
                res += word.Length - r;
                // update state by A[l]
                if (d.ContainsKey(word[l]))
                {
                    d[word[l]]--;
                }
                else
                {
                    ccount--;
                }
                l++;
            }
        }
        return res;
    }
}
