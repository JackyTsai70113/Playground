# Maximum subarray problem(最大子數列)

## 概念

在一個給定的整數序列中，找一個連續子序列，使得子序列的和最大。

dp 解法為依序取得以第 i 個元素結尾的的最大子序列和

## 解題

```csharp
// O(N), O(N)
public static int MaxSubArray1(int[] nums)
{
    var dp = new int[nums.Length];
    dp[0] = nums[0];
    int max = nums[0];
    for (int i = 1; i < nums.Length; i++)
    {
        dp[i] = Math.Max(dp[i - 1] + nums[i], nums[i]);
        max = Math.Max(max, dp[i]);
    }
    return max;
}
```

優化：可以發現解法1中每個dp[i] 只會被 dp[i-1] 影響，因此我們可以只用一個變數儲存 dp[i-1] 即可

```csharp
// O(N), O(N)
public static int MaxSubArray2(int[] nums)
{
    int sum = nums[0], max = nums[0];
    for (int i = 1; i < nums.Length; i++)
    {
        sum = Math.Max(sum + nums[i],nums[i]);
        max = Math.Max(max, sum);
    }
    return max;
}
```