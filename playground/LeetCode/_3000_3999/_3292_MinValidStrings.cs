namespace playground._3200_3299;

public class _3292_MinValidStrings
{
    public static int MinValidStrings(string[] words, string target)
    {
        int n = target.Length;
        // target 各元素所匹配word的最長長度
        var match = new int[n];
        foreach (var w in words)
        {
            var str = w + '#' + target;
            // target[0] 在 str 的 index
            int excess = w.Length + 1;
            int wordLen = w.Length;

            int nn = str.Length;
            int left = 0, right = 0; // l, r 定義了 z-box(已匹配prefix的滑動窗口)
            var z = new int[nn];
            for (int i = 1; i < nn; i++)
            {
                if (i <= right) // i 在 z-box 裡
                    z[i] = Math.Min(z[i - left], right - i + 1); // z函數核心思想
                while (i + z[i] < nn && str[z[i]] == str[i + z[i]])
                {
                    (left, right) = (i, i + z[i]);
                    z[i]++;
                }
                if (i >= excess && z[i] > 0)
                {
                    match[i - excess] = Math.Max(match[i - excess], z[i]);
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
        if (curEnd < n) return -1;
        return step;
    }
}
