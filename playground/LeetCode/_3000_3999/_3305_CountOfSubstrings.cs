namespace playground._3300_3399;

public class _3305_CountOfSubstrings
{
    public static int CountOfSubstrings(string word, int k)
    {
        int res = 0;
        var d = new Dictionary<char, int>
        {
            ['a'] = 0,
            ['e'] = 0,
            ['i'] = 0,
            ['o'] = 0,
            ['u'] = 0,
        };
        int ccount;
        bool Valid()
        {
            return d.Values.All(x => x > 0) && ccount == k;
        }
        for (int i = 0; i < word.Length; i++)
        {
            d = new Dictionary<char, int>
            {
                ['a'] = 0,
                ['e'] = 0,
                ['i'] = 0,
                ['o'] = 0,
                ['u'] = 0,
            };
            ccount = 0;
            for (int j = i; j < word.Length; j++)
            {
                if (d.ContainsKey(word[j]))
                    d[word[j]]++;
                else
                    ccount++;
                if (Valid())
                    res++;
                else if (ccount > k)
                    break;
            }
        }
        return res;
    }
}
