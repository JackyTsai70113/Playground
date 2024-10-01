namespace playground;

public class _2062_CountVowelSubstrings
{
    public static int CountVowelSubstrings(string word)
    {
        return AtMost(word, 5) - AtMost(word, 4);
    }

    private static int AtMost(string word, int k)
    {
        var d = new Dictionary<char, int>
        {
            ['a'] = 0,
            ['e'] = 0,
            ['i'] = 0,
            ['o'] = 0,
            ['u'] = 0,
        };
        int other = 0;
        bool Valid()
        {
            return k >= 0 && other == 0;
        }
        int res = 0;
        for (int l = 0, r = 0; r < word.Length; r++)
        {
            // update state by A[r]
            if (d.ContainsKey(word[r]))
            {
                if (d[word[r]] == 0)
                {
                    k--;
                }
                d[word[r]]++;
            }
            else
            {
                other++;
            }
            while (l <= r && !Valid())
            {
                // update state by A[l]
                if (d.ContainsKey(word[l]))
                {
                    d[word[l]]--;
                    if (d[word[l]] == 0)
                    {
                        k++;
                    }
                }
                else
                {
                    other--;
                }
                l++;
            }
            res += r - l + 1;
        }
        return res;
    }
}
