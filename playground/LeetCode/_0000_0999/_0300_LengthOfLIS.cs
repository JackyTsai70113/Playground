namespace playground.LeetCode._0000_0999;

public class _0300_LengthOfLIS
{
    public static int LengthOfLIS(int[] nums)
    {
        var monoList = new List<int>();
        int l, r, m;
        foreach (var num in nums)
        {
            l = 0; r = monoList.Count;
            while (l < r)
            {
                m = l + (r - l) / 2;
                if (monoList[m] >= num)
                {
                    r = m;
                }
                else
                {
                    l = m + 1;
                }
            }
            if (l == monoList.Count)
            {
                monoList.Add(num);
            }
            else
            {
                monoList[l] = num;
            }
        }
        return monoList.Count;
    }
}
