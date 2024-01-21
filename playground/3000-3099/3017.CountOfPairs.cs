namespace playground;

public class CountOfPairs3017
{
    /// <summary>
    /// https://leetcode.com/problems/count-the-number-of-houses-at-a-certain-distance-ii
    /// </summary>
    public static long[] CountOfPairs(int n, int x, int y)
    {
        if (x > y)
        {
            int t = x; x = y; y = t;
        }
        long[] A = new long[n];
        for (int i = 1; i <= n; ++i)
        {
            // 把 走到 i-1, i+1 的步數 +1, 也就是一步
            A[0] += 2;
            // 想辦法走到 0 然後把該步數 -1, 
            // 也就是 i-0 或是 Math.Abs(i-y)+1+x 的最小值
            A[Math.Min(i - 1, Math.Abs(i - y) + x)]--;
            // 想辦法走到 n+1 然後把該步數 -1, 
            // 也就是 n+1-i 或是 Math.Abs(i-x)+1+(n+1)-y 的最小值
            A[Math.Min(n - i, Math.Abs(i - x) + 1 + n - y)]--;
            // 想辦法走到 x-1, x+1 然後把該步數 -1, 
            // 也就是 Math.Abs(i - x)+1 或是 Math.Abs(i-y)+1+1 的最小值
            A[Math.Min(Math.Abs(i - x), Math.Abs(i - y) + 1)]++;
            // 想辦法走到 y-1, y+1 然後把該步數 -1, 
            // 也就是 Math.Abs(i-x)+1+1 或是 Math.Abs(i - y)+1 的最小值
            A[Math.Min(Math.Abs(i - x) + 1, Math.Abs(i - y))]++;

            // 刻意走 x-y 但沒有省步數的走法
            // e.g. 7,2,6 的 走到 2 再走到 6 再走到 3
            // e.g. 7,2,6 的 走到 6 再走到 2 再走到 4

            // (x,y,i)
            // (2,6,1) r為1 (走到2)
            // (2,6,3) r為0 (不走)
            // (2,6,4) r為0 (不走)
            // (2,6,7) r為1 (走到6)
            int r = Math.Max(x - i, 0) + Math.Max(i - y, 0);

            // 走遠路到中點的左側 i -> x -> y <- x
            A[r + (y - x + 0) / 2]--;                            // i -> x -> y <- x
            // 走遠路到中點的右側, i -> y -> x <- y
            A[r + (y - x + 1) / 2]--;                            // i -> y -> x <- y
        }
        for (int i = 1; i < n; ++i)
            A[i] += A[i - 1];
        return A;
    }
}
