namespace playground;

public class CanMeasureWater0365
{
    /// <summary>
    /// https://leetcode.com/problems/water-and-jug-problem
    /// </summary>
    public static bool CanMeasureWater(int a, int b, int target)
    {
        if (target > a + b)
            return false;

        static int gcd(int x, int y)
        {
            return y == 0 ? x : gcd(y, x % y);
        }
        return target % gcd(a, b) == 0;
    }

    public static bool CanMeasureWater2(int a, int b, int target)
    {
        if (target > a + b)
            return false;

        var q = new Queue<int>();
        var dp = new bool[a + b + 1];
        q.Enqueue(a);
        q.Enqueue(b);
        var dirs = new int[] { a, b, -a, -b };
        while (q.Count > 0)
        {
            var c = q.Dequeue();
            dp[c] = true;
            for (int i = 0; i < dirs.Length; ++i)
            {
                var next = c + dirs[i];
                if (next < 0 || next > a + b || dp[next])
                    continue;
                q.Enqueue(next);
            }
        }
        return dp[target];
    }
}

/*
3 5
3 0
0 3
3 3
1 5


*/
