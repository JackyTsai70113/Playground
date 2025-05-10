namespace playground.Algorithms;

public static class ZAlgorithm
{
    /// <summary>
    /// 計算 Z 陣列：<br/>
    /// z[i] 表示從位置 i 開始的子字串，與整個字串 s 的最長前綴相同的長度。
    /// </summary>
    /// <param name="s">要計算 Z 陣列的字串</param>
    /// <returns>返回 Z 陣列</returns>
    /// <remarks>
    /// https://www.youtube.com/watch?v=2EqYY0c--QI
    /// https://personal.utdallas.edu/~besp/demo/John2010/z-algorithm.htm
    /// </remarks>
    public static int[] ZFunction(string s)
    {
        int n = s.Length, l = 0, r = 0;
        int[] z = new int[n];
        for (int i = 1; i < n; i++)
        {
            // 如果 i 在 Z-box 裡，可以嘗試複用先前的 Z 值
            if (i < r)
                // 限制不能超出 Z-box 範圍
                z[i] = Math.Min(z[i - l], r - i);
            // 嘗試擴展 z[i]
            while (i + z[i] < n && s[z[i]] == s[i + z[i]])
                z[i]++;
            // 如果 z[i] 向右延伸超過了 r，更新 Z-box
            if (i + z[i] > r)
                (l, r) = (i, i + z[i]);
        }
        return z;
    }
}
