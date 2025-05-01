namespace playground;

public class _3072_ResultArray
{
    /// <summary>
    /// https://leetcode.com/problems/distribute-elements-into-two-arrays-ii
    /// </summary>
    public static int[] ResultArray(int[] nums)
    {
        List<int> l1 = new() { nums[0] }, l2 = new() { nums[1] };
        HashSet<int> s = new() { 0 };
        static int GetIndex(List<int> list, int val)
        {
            int l = 0, r = list.Count;
            while (l < r)
            {
                int m = l + (r - l) / 2;
                if (list[m] >= val + 1)
                    r = m;
                else
                    l = m + 1;
            }
            return l;
        }

        for (int i = 2; i < nums.Length; i++)
        {
            int idx1 = GetIndex(l1, nums[i]);
            int idx2 = GetIndex(l2, nums[i]);
            if (l1.Count - idx1 < l2.Count - idx2 ||
                l1.Count - idx1 == l2.Count - idx2 && l1.Count > l2.Count)
            {
                if (idx2 == l2.Count)
                    l2.Add(nums[i]);
                else
                    l2.Insert(idx2, nums[i]);
            }
            else
            {
                if (idx1 == l1.Count)
                    l1.Add(nums[i]);
                else
                    l1.Insert(idx1, nums[i]);
                s.Add(i);
            }
        }
        var res = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (s.Contains(i))
                res.Add(nums[i]);
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (!s.Contains(i))
                res.Add(nums[i]);
        }
        return res.ToArray();
    }
}
