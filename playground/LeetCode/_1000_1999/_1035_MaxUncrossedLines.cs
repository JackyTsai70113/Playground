namespace playground.LeetCode._1000_1999;

public class _1035_MaxUncrossedLines
{
    public static int MaxUncrossedLines_TopDown(int[] nums1, int[] nums2)
    {
        int n1 = nums1.Length, n2 = nums2.Length;
        var dp = new int[n1, n2];
        for (int i = 0; i < n1; i++)
            for (int j = 0; j < n2; j++)
                dp[i, j] = -1;
        int dfs(int i, int j)
        {
            if (i == n1 || j == n2) return 0;
            if (dp[i, j] != -1) return dp[i, j];

            dp[i, j] = 0;
            if (nums1[i] == nums2[j])
            {
                dp[i, j] = 1 + dfs(i + 1, j + 1);
            }
            else
            {
                dp[i, j] = Math.Max(dfs(i + 1, j), dfs(i, j + 1));
            }
            return dp[i, j];
        }
        return dfs(0, 0);
    }

    public static int MaxUncrossedLines_BottomUp(int[] nums1, int[] nums2)
    {
        int n1 = nums1.Length, n2 = nums2.Length;
        var dp = new int[n1 + 1, n2 + 1];
        for (int i = 1; i <= n1; i++)
        {
            for (int j = 1; j <= n2; j++)
            {
                if (nums1[i - 1] == nums2[j - 1])
                {
                    dp[i, j] = 1 + dp[i - 1, j - 1];
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }
        return dp[n1, n2];
    }

    public static int MaxUncrossedLines_OptimizeSpace(int[] nums1, int[] nums2)
    {
        int n1 = nums1.Length, n2 = nums2.Length;
        if (n1 < n2) return MaxUncrossedLines_OptimizeSpace(nums2, nums1);

        var dp = new int[n2 + 1];
        var dp2 = new int[n2 + 1];
        for (int i = 1; i <= n1; i++)
        {
            Array.Clear(dp2);
            for (int j = 1; j <= n2; j++)
            {
                if (nums1[i - 1] == nums2[j - 1])
                {
                    dp2[j] = 1 + dp[j - 1];
                }
                else
                {
                    dp2[j] = Math.Max(dp[j], dp2[j - 1]);
                }
            }
            (dp, dp2) = (dp2, dp);
        }
        return dp[n2];
    }
}
