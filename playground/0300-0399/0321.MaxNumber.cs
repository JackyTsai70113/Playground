namespace playground;

public class MaxNumber0321
{
    /// <summary>
    /// https://leetcode.com/problems/create-maximum-number
    /// </summary>
    public static int[] MaxNumber(int[] nums1, int[] nums2, int k)
    {
        var res = new int[k].ToList();
        var l1 = MaxSub(nums1.ToList(), k);
        var l2 = MaxSub(nums2.ToList(), k);
        for (int i = 0; i <= k; i++)
        {
            if (l1.Count >= i && l2.Count >= k - i)
            {
                var l3 = MaxSub(l1, i);
                var l4 = MaxSub(l2, k - i);
                var cur = Merge(l3, l4);
                res = Compare(res, cur, 0, 0) > 0 ? res : cur;
            }
        }
        return res.ToArray();
    }

    private static int Compare(List<int> l1, List<int> l2, int i, int j)
    {
        while (i < l1.Count || j < l2.Count)
        {
            int num1 = i < l1.Count ? l1[i] : int.MinValue;
            int num2 = j < l2.Count ? l2[j] : int.MinValue;
            if (num1 != num2)
                return num1.CompareTo(num2);
            i++; j++;
        }
        return 0;
    }

    private static List<int> Merge(List<int> l1, List<int> l2)
    {
        if (l1.Count == 0) return l2;
        if (l2.Count == 0) return l1;
        var res = new List<int>();
        int i = 0, j = 0;
        while (i < l1.Count || j < l2.Count)
        {
            if (Compare(l1, l2, i, j) > 0)
                res.Add(l1[i++]);
            else
                res.Add(l2[j++]);
        }
        return res;
    }

    private static List<int> MaxSub(List<int> l, int k)
    {
        if (k == 0) return new();
        if (l.Count <= k) return l;
        var st = new Stack<int>();
        for (int i = 0; i < l.Count; i++)
        {
            while (st.Count + l.Count - i > k && st.Count > 0 && l[st.Peek()] < l[i])
                st.Pop();
            if (st.Count < k)
                st.Push(i);
        }
        var res = new List<int>();
        while (k-- > 0 && st.Count > 0)
        {
            res.Insert(0, l[st.Pop()]);
        }
        return res;
    }
}
