namespace playground;

public class VideoStitching1024
{
    /// <summary>
    /// https://leetcode.com/problems/video-stitching
    /// </summary>
    /// <remarks>
    /// Time O(NlogN + NT), Space O(T)
    /// </remarks> 
    public static int VideoStitching(int[][] clips, int T)
    {
        var memo = new int[101];
        Array.Fill(memo, 101);
        memo[0] = 0;

        Array.Sort(clips, (x, y) => x[0] - y[0]);
        foreach (var c in clips)
        {
            if (memo[c[0]] == 101)
                continue;
            for (int i = c[0] + 1; i <= c[1]; i++)
            {
                memo[i] = Math.Min(memo[i], memo[c[0]] + 1);
            }
        }
        return memo[T] == 101 ? -1 : memo[T];
    }

    /// <remarks>
    /// Time O(NlogN), Space O(1)
    /// </remarks>
    public static int VideoStitching2(int[][] clips, int T)
    {
        Array.Sort(clips, (x, y) => x[0] - y[0]);
        int res = 0, st = 0, end = 0;
        for (; st < T; st = end, res++)
        {
            // 找所有 clip 能從 st 開始接的，並設定 end，也就是新 st
            for (int i = 0; i < clips.Length && clips[i][0] <= st; i++)
                end = Math.Max(end, clips[i][1]);
            if (st == end) return -1;
        }
        return res;
    }
}
