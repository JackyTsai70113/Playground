namespace playground.Mathematics;

public class NumOfWaysClass
{
    readonly int MOD = (int)(1e9 + 7);
    int[,] binomialCoefficients;
    /// <summary>
    /// https://leetcode.com/problems/number-of-ways-to-reorder-array-to-get-same-bst
    /// </summary>
    public int NumOfWays(int[] nums)
    {
        SetBinomialCoefficient(nums.Length);

        long dp(List<int> l)
        {
            if (l.Count <= 2)
                return 1;
            List<int> left = new(), right = new();
            for (int i = 1; i < l.Count; ++i)
            {
                if (l[i] < l[0])
                    left.Add(l[i]);
                else
                    right.Add(l[i]);
            }
            long res = binomialCoefficients[l.Count - 1, left.Count];
            res = res * dp(left) % MOD;
            res = res * dp(right) % MOD;
            return res;
        }
        return (int)dp(nums.ToList()) - 1;
    }

    void SetBinomialCoefficient(int n)
    {
        binomialCoefficients = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            binomialCoefficients[i, 0] = 1;
            binomialCoefficients[i, i] = 1;
        }

        for (int i = 1; i < n; ++i)
        {
            for (int j = 1; j <= i; j++)
            {
                binomialCoefficients[i, j] =
                    (binomialCoefficients[i - 1, j - 1] +
                    binomialCoefficients[i - 1, j]) % MOD;
            }
        }
    }
}
