namespace playground._0900_0999;

public class _0992_SubarraysWithKDistinct
{
    public static int SubarraysWithKDistinct(int[] nums, int k)
    {
        return AtMost(nums, k) - AtMost(nums, k - 1);
    }

    private static int AtMost(int[] nums, int k)
    {
        bool Valid()
        {
            return k >= 0;
        }
        int res = 0;
        var d = new Dictionary<int, int>();
        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            // update state by A[r]
            if (d.ContainsKey(nums[r]) && d[nums[r]] > 0)
            {
                d[nums[r]]++;
            }
            else
            {
                d[nums[r]] = 1;
                k--;
            }
            while (!Valid())
            {
                // update state by A[l]
                d[nums[l]]--;
                if (d[nums[l]] == 0)
                {
                    k++;
                }
                l++;
            }
            res += r - l + 1;
        }
        return res;
    }
}
