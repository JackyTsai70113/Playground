namespace playground.LeetCode._0000_0999;

public class _0368_LargestDivisibleSubset
{
    public static IList<int> LargestDivisibleSubset(int[] nums)
    {
        Array.Sort(nums);
        var len = new int[nums.Length];
        var par = new int[nums.Length];
        int maxLength = 0, maxi = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            par[i] = -1;
            len[i] = 1;
            for (int j = 0; j < i; j++)
            {
                if (nums[i] % nums[j] == 0)
                {
                    if (len[j] + 1 > len[i])
                    {
                        len[i] = len[j] + 1;
                        par[i] = j;
                    }
                }
            }
            if (len[i] > maxLength)
            {
                maxLength = len[i];
                maxi = i;
            }
        }

        var res = new List<int>();
        while (maxi != -1)
        {
            res.Add(nums[maxi]);
            maxi = par[maxi];
        }
        return res;
    }
}
