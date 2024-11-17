namespace playground._3300_3399;

public class _3321_FindXSum
{
    public static long[] FindXSum(int[] nums, int k, int x)
    {
        int n = nums.Length;
        var res = new long[n - k + 1];
        var count = new Dictionary<int, int>();
        TopKFreq topKFreq = new(x);
        for (int i = 0; i < n; i++)
        {
            count[nums[i]] = count.GetValueOrDefault(nums[i]) + 1;
            if (count[nums[i]] > 1)
            {
                topKFreq.Remove(nums[i], count[nums[i]] - 1);
            }
            topKFreq.Insert(nums[i], count[nums[i]]);
            if (i >= k - 1)
            {
                if (i >= k)
                {
                    topKFreq.Remove(nums[i - k], count[nums[i - k]]);
                    count[nums[i - k]]--;
                    if (count[nums[i - k]] > 0)
                    {
                        topKFreq.Insert(nums[i - k], count[nums[i - k]]);
                    }
                }
                res[i - k + 1] = topKFreq.GetSum();
            }
        }
        return res;
    }

    public class TopKFreq
    {
        private readonly int k;
        private long sum;
        private List<(int val, int count)> list;

        public TopKFreq(int k)
        {
            this.k = k;
            list = new();
            sum = 0;
        }

        public void Insert(int val, int count)
        {
            int index = BinarySearch(val, count);
            list.Insert(index, (val, count));
            if (list.Count - 1 - index + 1 <= k)
            {
                sum += (long)val * count;
                if (list.Count - 1 - k >= 0)
                {
                    sum -= (long)list[list.Count - 1 - k].val * list[list.Count - 1 - k].count;
                }
            }
        }

        public void Remove(int val, int count)
        {
            int index = BinarySearch(val, count);
            if (list.Count - 1 - index + 1 <= k)
            {
                sum -= (long)val * count;
                if (list.Count - 1 - k >= 0)
                {
                    sum += (long)list[list.Count - 1 - k].val * list[list.Count - 1 - k].count;
                }
            }
            list.RemoveAt(index);
        }

        public long GetSum()
        {
            return sum;
        }
        private int BinarySearch(int val, int count)
        {
            int l = 0, r = list.Count;
            while (l < r)
            {
                int m = l + (r - l) / 2;
                if (list[m].count > count ||
                list[m].count == count && list[m].val >= val)
                {
                    r = m;
                }
                else
                {
                    l = m + 1;
                }
            }
            return l;
        }
    }
}
