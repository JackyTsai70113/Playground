namespace playground;

public class MinPatches_0330
{
    /// <summary>
    /// https://leetcode.com/problems/patching-array
    /// </summary>
    public static int MinPatches(int[] nums, int n)
    {
        long lastMiss = 1;
        int i = 0, res = 0;
        while (lastMiss <= n)
        {
            if (i < nums.Length && lastMiss >= nums[i])
            {
                lastMiss = lastMiss + nums[i++];
            }
            else
            {
                lastMiss *= 2;
                res++;
            }
        }
        return res;
    }
}
