namespace playground;

/// <summary>
/// https://leetcode.com/problems/random-point-in-non-overlapping-rectangles
/// </summary>
public class Solution0497
{
    long[] presum;
    int[][] rects;
    readonly Random random = new();
    public Solution0497(int[][] rects)
    {
        this.rects = rects;
        presum = new long[rects.Length + 1];
        for (int i = 0; i < rects.Length; i++)
        {
            var r = rects[i];
            var cur = ((long)r[2] - r[0] + 1) * ((long)r[3] - r[1] + 1);
            presum[i + 1] = presum[i] + cur - 1;
        }
    }

    public int[] Pick()
    {
        long cur = random.NextInt64(presum[^1]);
        var index = GetMaxIndex(presum, cur) - 1;
        int row = rects[index][2] - rects[index][0] + 1;
        return new int[] { rects[index][0] + (int)(cur / row), rects[index][1] + (int)(cur % row) };
    }

    public int GetMaxIndex(long[] presum, long val)
    {
        int l = 0, r = presum.Length - 1;
        while (l < r)
        {
            int m = l + (r - l + 1) / 2;
            if (presum[m] <= val)
                l = m;
            else
                r = m - 1;
        }
        return r;
    }
}