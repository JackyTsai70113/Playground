namespace playground.LeetCode._3000_3999;

public class _3439_MaxFreeTime
{
    public static int MaxFreeTime(int eventTime, int k, int[] startTime, int[] endTime)
    {
        int n = startTime.Length;
        var prefix = new int[n + 1];
        for (int i = 0; i < n; i++)
            prefix[i + 1] = prefix[i] + (endTime[i] - startTime[i]);
        if (k == n)
            return eventTime - prefix[n];

        // 從 i 開始往後移動 k 個
        int max = 0;
        for (int i = 0; i <= n - k; i++)
        {
            // i == 0: 從 0 開始移的話, left = 0
            int left = i == 0 ? 0 : endTime[i - 1];
            // i == n - k: 已經移完所能移的了
            int right = i == n - k ? eventTime : startTime[i + k];
            int freeTime = right - left - prefix[i + k] + prefix[i];
            max = Math.Max(max, freeTime);
        }
        return max;
    }
}
