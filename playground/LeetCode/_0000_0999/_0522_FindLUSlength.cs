namespace playground.LeetCode._0000_0999;

public class _0522_FindLUSlength
{
    public static int FindLUSlength(string[] strs)
    {
        Array.Sort(strs, (x, y) => y.Length - x.Length);
        var (set, dups) = Dups(strs);
        strs = set.ToArray();
        for (int i = 0; i < strs.Length; i++)
        {
            if (dups.Contains(strs[i]))
                continue;
            if (i == 0) return strs[0].Length;
            int j = 0;
            for (; j < i; j++)
            {
                if (IsSub(strs[i], strs[j]))
                    break;
            }
            if (j == i)
                return strs[i].Length;
        }
        return -1;
    }

    static bool IsSub(string str1, string str2)
    {
        int i = 0;
        for (int j = 0; i < str1.Length && j < str2.Length; j++)
        {
            if (str1[i] == str2[j])
            {
                i++;
            }
        }
        return i == str1.Length;
    }

    static (HashSet<string>, HashSet<string>) Dups(string[] strs)
    {
        HashSet<string> set = new(), dups = new();
        foreach (var str in strs)
        {
            if (set.Contains(str)) dups.Add(str);
            set.Add(str);
        }
        return (set, dups);
    }
}
