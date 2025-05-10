using playground.Helpers;

namespace playground.LeetCode._3000_3999;

public class _3272_CountGoodIntegers
{
    private long res = 0;
    private int n;
    private int k;
    private long[] factorial;
    public long CountGoodIntegers(int n, int k)
    {
        this.n = n;
        this.k = k;

        factorial = MathHelper.Factorials(n);

        Dfs(new List<int>(), new HashSet<string>());
        return res;
    }

    private void Dfs(List<int> nums, HashSet<string> seen)
    {
        if (nums.Count == (n + 1) / 2)
        {
            // 排除開頭是 0 的情況（除了單位數）
            if (n > 1 && nums[0] == 0)
                return;

            (long cur, int[] digitCounts) = BuildPalindrome(nums);
            if (cur % k != 0)
                return;

            var key = string.Join("", digitCounts);
            if (!seen.Add(key))
                return;

            long perms = (n - digitCounts[0]) * factorial[n - 1];
            foreach (var digitCount in digitCounts)
                perms /= factorial[digitCount];

            res += perms;
            return;
        }

        for (int j = 0; j <= 9; j++)
        {
            nums.Add(j);
            Dfs(nums, seen);
            nums.RemoveAt(nums.Count - 1);
        }
    }

    private (long cur, int[] digitsCount) BuildPalindrome(List<int> nums)
    {
        long res = 0;
        int[] digitsCount = new int[10];
        for (int i = 0; i < nums.Count; i++)
        {
            res = res * 10 + nums[i];
            digitsCount[nums[i]]++;
        }

        int rightStart = n % 2 == 0 ? nums.Count - 1 : nums.Count - 2;

        for (int i = rightStart; i >= 0; i--)
        {
            res = res * 10 + nums[i];
            digitsCount[nums[i]]++;
        }

        return (res, digitsCount);
    }
}
