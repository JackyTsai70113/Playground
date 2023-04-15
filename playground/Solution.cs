namespace playground;

public class Solution
{
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

    public static int MakeConnected(int n, int[][] A)
    {
        if (A.Length < n - 1)
        {
            return -1;
        }
        var graph = Enumerable.Range(0, n).Select(x => new List<int>()).ToArray();
        foreach (var a in A)
        {
            graph[a[0]].Add(a[1]);
            graph[a[1]].Add(a[0]);
        }

        var seen = new bool[n];
        void dfs(int x)
        {
            seen[x] = true;
            foreach (var neighbor in graph[x])
            {
                if (!seen[neighbor])
                {
                    dfs(neighbor);
                }
            }
        }

        var componentsCount = -1;
        for (int i = 0; i < n; ++i)
        {
            if (!seen[i])
            {
                componentsCount++;
                dfs(i);
            }
        }
        return componentsCount;
    }

    public static long CountPairs(int n, int[][] edges)
    {
        var graph = Enumerable.Range(0, n).Select(x => new List<int>()).ToArray();
        foreach (var e in edges)
        {
            graph[e[0]].Add(e[1]);
            graph[e[1]].Add(e[0]);
        }

        var seen = new bool[n];
        List<int> components = new();

        int dfs(int i)
        {
            if (seen[i])
            {
                return 0;
            }
            seen[i] = true;
            var count = 1;
            foreach (var nei in graph[i])
            {
                count += dfs(nei);
            }
            return count;
        }

        long res = 0;
        long count = 0;
        for (int i = 0; i < n; ++i)
        {
            if (!seen[i])
            {
                long componentsCount = dfs(i);
                count += componentsCount;
                res += componentsCount * (n - count);
            }
        }
        return res;
    }
}