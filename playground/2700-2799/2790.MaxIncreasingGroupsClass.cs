namespace playground;

public class MaxIncreasingGroupsClass
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-number-of-groups-with-increasing-length
    /// </summary>
    public static int MaxIncreasingGroups(IList<int> usageLimits)
    {
        usageLimits = usageLimits.OrderBy(x => x).ToList();
        long count = 0; int k = 0;
        for (int i = 0; i < usageLimits.Count; ++i)
        {
            count += usageLimits[i];
            if (count >= (k + 1) * (k + 2) / 2)
                k++;
        }
        return k;
    }
}
