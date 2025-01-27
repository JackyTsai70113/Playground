namespace playground._3400_3499;

public class _3434_MaxFrequency
{
    public static int MaxFrequency(int[] nums, int k)
    {
        var set = nums.ToHashSet();
        int maxInSubArray = 0; // 改變的子數列的 max
        int kCount = nums.Count(x => x == k);
        foreach (var m in set)
        {
            if (m == k) continue; // 不用算 m==k, 可以用 kCount
            int maxAtThisIndex = 0, maxSoFar = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int x;
                if (nums[i] == m) // 將 nums[i] 替換成 k，要加一
                    x = 1;
                else if (nums[i] == k) // 會把 k 換掉，要減一
                    x = -1;
                else // 會替換成不是 k 的數字，不影響
                    x = 0;

                // Kadane's algorithm: 持續考慮當前 index, 是否要加上前面的子數列。計算最大的 sum array sum
                maxAtThisIndex = Math.Max(
                    maxAtThisIndex + x, // 考慮前面數列加上自己
                    x // 不考慮前面數列，只考慮自己
                );
                maxSoFar = Math.Max(maxSoFar, maxAtThisIndex);
            }
            maxInSubArray = Math.Max(maxInSubArray, maxSoFar);
        }
        return maxInSubArray + kCount;
    }
}
