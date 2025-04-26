namespace playground._2500_2599;

public class _2563_CountFairPairs
{
    public static long CountFairPairs(int[] nums, int lower, int upper)
    {
        long res = 0;
        var orderList = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int l = 0, r = orderList.Count;
            while (l < r)
            {
                int m = l + (r - l) / 2;
                if (nums[i] + orderList[m] >= lower)
                    r = m;
                else
                    l = m + 1;
            }
            int left = l;

            l = 0;
            r = orderList.Count;
            while (l < r)
            {
                int m = l + (r - l) / 2;
                if (nums[i] + orderList[m] > upper)
                    r = m;
                else
                    l = m + 1;
            }
            int right = l;

            res += right - left;

            l = 0;
            r = orderList.Count;
            while (l < r)
            {
                int m = l + (r - l) / 2;
                if (orderList[m] > nums[i])
                    r = m;
                else
                    l = m + 1;
            }
            orderList.Insert(l, nums[i]);
        }
        return res;
    }
}
