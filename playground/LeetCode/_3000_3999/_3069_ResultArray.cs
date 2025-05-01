namespace playground;

public class _3069_ResultArray
{
    /// <summary>
    /// https://leetcode.com/problems/distribute-elements-into-two-arrays-i
    /// </summary>
    public static int[] ResultArray(int[] nums)
    {
        List<int> a = new(), b = new();
        a.Add(nums[0]);
        b.Add(nums[1]);
        for (int i = 2; i < nums.Length; i++)
        {
            if (a[^1] > b[^1])
                a.Add(nums[i]);
            else
                b.Add(nums[i]);
        }
        return a.Concat(b).ToArray();
    }
}
