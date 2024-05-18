namespace playground;

public class Solution
{
    // public int[] FindPermutation(int[] nums)
    // {
    //     int n = nums.Length;
    //     int[] res = new int[n], memo = new int[n];
    //     res[0] = 0;
    //     for (int i = 0; i < n; i++) memo[nums[i]] = i;
    //     var set = new HashSet<int>();
    //     if (nums[0] == n - 1)
    //     {
    //         res[n - 1] = n - 1;
    //         set.Add(n - 1);
    //     }
    //     for (int i = 1; i < n; i++)
    //     {
    //         int num = res[i - 1];
    //         while (set.Contains(memo[num]))
    //         {
    //             num = (num + 1) % n;
    //         }
    //         set.Add(memo[num]);
    //         res[i] = memo[num];
    //     }
    //     return res;
    // }
}