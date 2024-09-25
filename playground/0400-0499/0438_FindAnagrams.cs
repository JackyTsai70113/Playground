namespace playground;

public class _0438_FindAnagrams
{
    public static IList<int> FindAnagrams(string s, string p)
    {
        int[] count = new int[s.Length];
        bool Valid()
        {
            for (int i = 0; i < 26; i++)
            {
                if (count[i] != 0)
                    return false;
            }
            return true;
        }
        int l = 0;
        List<int> res = new();
        foreach (var c in p)
        {
            count[c - 'a']++;
        }
        for (int r = 0; r < s.Length; r++)
        {
            // update state by A[r]
            count[s[r] - 'a']--;
            while (l <= r && !Valid())
            {
                // update state by A[l]
                count[s[l] - 'a']++;
                l++;
            }
            if (Valid())
                res.Add(l);
        }
        return res;
    }
}
