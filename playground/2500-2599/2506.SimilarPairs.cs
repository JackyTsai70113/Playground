namespace playground;

public class SimilarPairs2506
{
    /// <summary>
    /// https://leetcode.com/problems/count-pairs-of-similar-strings
    /// </summary>
    public static int SimilarPairs(string[] words)
    {
        var d = new Dictionary<int, int>();
        var res = 0;
        foreach (var w in words)
        {
            int num = 0;
            foreach (var c in w)
            {
                num |= 1 << (c - 'a');
            }
            if (!d.ContainsKey(num))
                d[num] = 0;
            res += d[num]++;
        }
        return res;
    }
}
