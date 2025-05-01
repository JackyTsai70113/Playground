namespace playground.LeetCode._0000_0999;

public class _0053_MaxSubArray
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-subarray
    /// </summary>
    public static int MaxSubArray(int[] nums)
    {
        int sum = 0, res = int.MinValue;
        foreach (var num in nums)
        {
            res = Math.Max(res, sum + num);
            sum = Math.Max(0, sum + num);
        }
        return res;
    }
}

// 55 15 35

// BAD LANDS
// My Broken Mariko
// 信用詐欺師
// 垃圾頭
// 《做工的人》電影版（Workers）
// 聽我的電波吧
// 跳槽的魔王大人