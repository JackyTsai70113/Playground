namespace playground;

public class PartitionString2405
{
    /// <summary>
    /// https://leetcode.com/problems/optimal-partition-of-string
    /// </summary>
    public static int PartitionString(string s)
    {
        int res = 1;
        var chs = new bool[26];
        foreach (var c in s)
        {
            if (chs[c - 'a'])
            {
                chs = new bool[26];
                res++;
            }
            chs[c - 'a'] = true;
        }
        return res;
    }
}