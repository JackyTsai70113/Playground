namespace playground;

public class MaxSubArray0053
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-subarray
    /// </summary>
    public static int MaxSubArray(int[] nums) {
        int sum = 0, res = int.MinValue;
        foreach(var num in nums){
            sum += num;
            res = Math.Max(res, sum);
            if(sum<0) sum = 0;
        }
        return res;
    }
}
