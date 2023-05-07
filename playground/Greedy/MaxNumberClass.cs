namespace playground.Greedy;

public class MaxNumberClass
{
    /// <remarks>https://leetcode.com/problems/create-maximum-number/</remarks>
    public static int[] MaxNumber(int[] nums1, int[] nums2, int k)
    {
        var l1 = MaxSub(nums1.ToList(), k);
        var l2 = MaxSub(nums2.ToList(), k);

        var res = new List<int>();
        for (int i = 0; i <= k; ++i)
        {
            if (i <= l1.Count && (k - i) <= l2.Count)
            {
                var sub1 = MaxSub(l1, i);
                var sub2 = MaxSub(l2, k - i);
                var merged = Merge(sub1, sub2);
                res = Compare(res, merged, 0, 0) > 0 ? res : new List<int>(merged);
            }
        }
        return res.ToArray();
    }

    private static List<int> Merge(List<int> l1, List<int> l2)
    {
        var res = new List<int>();
        int i = 0, j = 0;
        while (i < l1.Count || j < l2.Count)
        {
            if (i == l1.Count)
            {
                res.Add(l2[j++]);
            }
            else if (j == l2.Count)
            {
                res.Add(l1[i++]);
            }
            else if (Compare(l1, l2, i, j) > 0)
            {
                res.Add(l1[i++]);
            }
            else
            {
                res.Add(l2[j++]);
            }
        }
        return res;
    }

    private static List<int> MaxSub(List<int> nums, int k)
    {
        if (k >= nums.Count) return nums;
        var res = new List<int>();
        for (int i = 0; i < nums.Count; ++i)
        {
            while (res.Count > 0 && res.Count + nums.Count - i > k && nums[i] > res[^1])
            {
                res.RemoveAt(res.Count - 1);
            }
            if (res.Count < k)
            {
                res.Add(nums[i]);
            }
        }
        return res;
    }

    private static int Compare(List<int> l1, List<int> l2, int x, int y)
    {
        for (int i = 0; i < Math.Max(l1.Count - x, l2.Count - y); i++)
        {
            var digit1 = x + i < l1.Count ? l1[x + i] : 0;
            var digit2 = y + i < l2.Count ? l2[y + i] : 0;
            if (digit1 != digit2)
            {
                return digit1.CompareTo(digit2);
            }
        }
        return 0;
    }
}
