namespace playground;

public class DistributeCandies_2928
{
    /// <summary>
    /// https://leetcode.com/problems/distribute-candies-among-children-i
    /// </summary>
    public static int DistributeCandies(int n, int limit)
    {
        var res = 0;
        void dfs(int start, int curCandies)
        {
            if (start == 2)
            {
                if (curCandies <= limit)
                    res++;
                return;
            }
            if ((3 - start) * limit < curCandies)
                return;
            for (int i = 0; i <= Math.Min(limit, curCandies); ++i)
            {
                dfs(start + 1, curCandies - i);
            }
        }
        dfs(0, n);
        return res;
    }
}
