namespace playground;

/// <summary>
/// https://leetcode.com/problems/random-point-in-non-overlapping-rectangles
/// </summary>
public class Solution0497
{
    readonly long[] presum;
    readonly int[][] rects;
    readonly Random random = new();
    public Solution0497(int[][] rects)
    {
        this.rects = rects;
        presum = new long[rects.Length + 1];
        for (int i = 0; i < rects.Length; i++)
        {
            var r = rects[i];
            var cur = ((long)r[2] - r[0] + 1) * ((long)r[3] - r[1] + 1);
            presum[i + 1] = presum[i] + cur;
        }
    }

    public int[] Pick()
    {
        long cur = random.NextInt64(presum[^1]);
        var r = rects[GetMaxIndex(presum, cur) - 1];
        return new int[] {
            r[0] + random.Next(r[2] - r[0] + 1),
            r[1] + random.Next(r[3] - r[1] + 1)
        };
    }

    static int GetMaxIndex(long[] presum, long val)
    {
        int l = 1, r = presum.Length;
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (presum[m] > val)
                r = m;
            else
                l = m + 1;
        }
        return r;
    }
}