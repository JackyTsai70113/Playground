namespace playground.LeetCode._3000_3999;

public class _3434_MaxFrequency
{
    public static int MaxFrequency(int[] nums, int k)
    {
        var set = nums.ToHashSet();
        int maxf = 0, kCount = nums.Count(x => x == k);
        foreach (var m in set)
        {
            if (m == k) continue;
            int subSum = 0, maxSubSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int x;
                if (nums[i] == m) // 將 nums[i] 替換成 k，要加一
                    x = 1;
                else if (nums[i] == k) // 會把 k 換掉，要減一
                    x = -1;
                else // 會替換成不是 k 的數字，不影響
                    x = 0;

                subSum = Math.Max(x, subSum + x);
                maxSubSum = Math.Max(maxSubSum, subSum);
            }
            maxf = Math.Max(maxf, maxSubSum);
        }
        return maxf + kCount;
    }
}
