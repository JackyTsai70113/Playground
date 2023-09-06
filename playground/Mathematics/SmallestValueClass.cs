namespace playground.Mathematics;

public class SmallestValueClass
{
    /// <summary>
    /// https://leetcode.com/problems/smallest-value-after-replacing-with-sum-of-prime-factors
    /// </summary>
    public static int SmallestValue(int n)
    {
        int sum = 0;
        while (true)
        {
            sum = 0;
            for (int i = 2; i <= (int)Math.Sqrt(n); ++i)
            {
                while (n % i == 0)
                {
                    n /= i;
                    sum += i;
                }
            }
            if (n > 1) sum += n;
            if (sum == n) break;
            n = sum;
        }
        return sum;
    }
}
