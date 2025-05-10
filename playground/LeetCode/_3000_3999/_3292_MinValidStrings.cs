using playground.Algorithms;

namespace playground._3200_3299;

public class _3292_MinValidStrings
{
    public static int MinValidStrings(string[] words, string target)
    {
        int n = target.Length;
        var match = new int[n];

        foreach (var w in words)
        {
            string concat = w + "#" + target;
            int[] z = ZAlgorithm.ZFunction(concat);
            int offset = w.Length + 1;

            for (int i = offset; i < z.Length; i++)
            {
                if (z[i] > 0)
                {
                    int idx = i - offset;
                    if (idx < n)
                        match[idx] = Math.Max(match[idx], z[i]);
                }
            }
        }
        // greedy algorithm
        int step = 0, curEnd = 0, farthest = 0;
        for (int i = 0; i < n; i++)
        {
            farthest = Math.Max(farthest, i + match[i]);
            if (i == curEnd)
            {
                step++;
                curEnd = farthest;
                if (curEnd >= n) break;
            }
        }
        return curEnd < n ? -1 : step;
    }
}
