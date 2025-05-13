namespace playground.LeetCode._3000_3999;

public class _3411_MaxLength
{
    public static int MaxLength(int[] nums)
    {
        if (nums.Length == 2) return 2;
        int n = nums.Length;
        int res = 2;
        var set = new HashSet<int>();
        for (int i = 0; i < n; i++)
        {
            set.Clear();
            for (int j = i; j < n; j++)
            {
                bool isValid = true;
                for (int k = 2; k <= nums[j]; k++)
                {
                    if (nums[j] % k == 0 && !set.Add(k))
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid)
                {
                    res = Math.Max(res, j - i + 1);
                }
                else
                {
                    break;
                }
            }
        }
        return res;
    }
}
