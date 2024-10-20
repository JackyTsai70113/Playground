namespace playground._3000_3099;

public class _3013_MinimumCost
{
    public static long MinimumCost(int[] nums, int k, int dist)
    {
        long minSum = long.MaxValue;
        Window window = new Window(k - 2);
        for (int l = 1 + 1; l < Math.Min(1 + dist, nums.Length - 1); l++)
        {
            window.Insert(nums[l]);
        }
        for (int i = 1; i < nums.Length - (k - 2); ++i)
        {
            if (i + dist < nums.Length)
            {
                window.Insert(nums[i + dist]);
            }
            long temp = nums[0] + nums[i] + window.MinSum();
            minSum = Math.Min(minSum, temp);
            window.Remove(nums[i + 1]);
        }
        return minSum;
    }
    private class Window
    {
        List<long> list = new();
        public long sum = 0;
        private int minWinSize = 0;
        public Window(int minWinSize)
        {
            this.minWinSize = minWinSize;
        }
        public void Insert(int val)
        {
            int index = BinarySearch(val);
            if (index >= 0)
            {
                list.Insert(index, val);
            }
            else
            {
                list.Add(val);
                index = list.Count - 1;
            }
            if (index < minWinSize)
            {
                sum += list[index];
                if (minWinSize < list.Count)
                {
                    sum -= list[minWinSize];
                }
            }
        }
        public void Remove(int val)
        {
            int index = BinarySearch(val);
            if (index >= 0)
            {
                if (index < minWinSize)
                {
                    sum -= list[index];
                    if (minWinSize < list.Count)
                    {
                        sum += list[minWinSize];
                    }
                }
                list.RemoveAt(index);
            }
        }
        public long MinSum()
        {
            return this.sum;
        }
        public int BinarySearch(int val)
        {
            if (list.Count == 0)
            {
                return -1;
            }
            int l = 0, r = list.Count - 1;
            int mid = (l + r) / 2;
            if (val > list[r])
            {
                return -1;
            }
            while (l < r)
            {
                if (list[mid] < val)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid;
                }
                mid = (l + r) / 2;
            }
            return r;
        }
    }
    // public static long MinimumCost2(int[] nums, int k, int dist)
    // {
    //     var list = new List<int>();
    //     long sum = 0, res = long.MaxValue;
    //     for (int l = 1, r = 1; r < nums.Length; r++)
    //     {
    //         var lowestRIndex = LowestIndex(list, nums[r]);
    //         list.Insert(lowestRIndex, nums[r]);
    //         sum += nums[r];
    //         while (list.Count > k - 1)
    //         {
    //             var lowestLIndex = LowestIndex(list, nums[l]);
    //             if (r - l > dist && (lowestLIndex == list.Count || list[lowestLIndex] != nums[l]))
    //             {
    //                 l++;
    //                 continue;
    //             }
    //             if (r - l > dist)
    //             {
    //                 sum -= nums[l];
    //                 list.RemoveAt(lowestLIndex);
    //                 l++;
    //             }
    //             else
    //             {
    //                 if (list[^1] == nums[l])
    //                 {
    //                     l++;
    //                 }
    //                 sum -= list[^1];
    //                 list.RemoveAt(list.Count - 1);
    //             }
    //         }
    //         if (list.Count == k - 1)
    //         {
    //             res = Math.Min(res, nums[0] + sum);
    //             Console.WriteLine(sum + " " + res);
    //         }
    //     }
    //     return res;
    // }

    // public static int LowestIndex(List<int> list, int val)
    // {
    //     int l = 0, r = list.Count;
    //     while (l < r)
    //     {
    //         int m = l + (r - l) / 2;
    //         if (list[m] >= val)
    //             r = m;
    //         else
    //             l = m + 1;
    //     }
    //     return r;
    // }
}
