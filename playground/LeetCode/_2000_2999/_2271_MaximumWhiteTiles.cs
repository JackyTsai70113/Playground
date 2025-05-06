namespace playground.LeetCode._2000_2999;

public class _2271_MaximumWhiteTiles
{
    public static int MaximumWhiteTiles(int[][] tiles, int len)
    {
        int n = tiles.Length;
        Array.Sort(tiles, (a, b) => a[0].CompareTo(b[0]));
        int res = 0, left = 0; ;
        var presum = new int[n + 1];
        for (int i = 0; i < n; i++)
            presum[i + 1] = presum[i] + tiles[i][1] - tiles[i][0] + 1;

        for (int right = 0; right < n; right++)
        {
            int carpetStart = tiles[right][1] - len + 1;
            while (tiles[left][1] < carpetStart)
                left++;

            int fullCover = presum[right + 1] - presum[left + 1]; //[l+1, r-1]
            int partialCover = tiles[left][1] - Math.Max(tiles[left][0], carpetStart) + 1; // [l]
            res = Math.Max(res, fullCover + partialCover);
            if (res == len) break;
        }
        return res;
    }
}
