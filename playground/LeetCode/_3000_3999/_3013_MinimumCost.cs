namespace playground._3000_3099;

public class _3013_MinimumCost
{
    public static long MinimumCost(int[] nums, int k, int dist)
    {
        var list = new List<int>();
        long sum = 0, res = long.MaxValue;
        int windowSize = k - 1;
        for (int l = 1, r = 1; r < nums.Length; r++)
        {
            // update state by A[r]
            var lowestRIndex = LowestIndex(list, nums[r]);
            list.Insert(lowestRIndex, nums[r]);
            if (lowestRIndex < windowSize) // right value 在 window 內
            {
                sum += nums[r];
                if (windowSize < list.Count) // list 裡超出 window 的要扣掉
                {
                    sum -= list[windowSize];
                }
            }
            if (r >= dist + 2)
            {
                // update state by A[l]
                var lowestLIndex = LowestIndex(list, nums[l]);
                if (lowestLIndex != -1) // 存在 list 裡面
                {
                    if (lowestLIndex < windowSize) // left value 在 window 內
                    {
                        sum -= nums[l];
                        if (windowSize < list.Count) // list 裡超出 window 的要加回
                        {
                            sum += list[windowSize];
                        }
                    }
                    list.RemoveAt(lowestLIndex);
                }
                l++;
            }
            // deal with res
            if (r >= windowSize)
            {
                res = Math.Min(res, nums[0] + sum);
            }
        }
        return res;
    }
    public static int LowestIndex(List<int> list, int val)
    {
        int l = 0, r = list.Count;
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (list[m] >= val)
                r = m;
            else
                l = m + 1;
        }
        return r;
    }
}
