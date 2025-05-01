namespace playground.LeetCode._2000_2999;

public class _2916_SumCounts
{
    private static readonly long N = 100005;
    private readonly long hell = 1000000007;
    private readonly long[] a = new long[N];
    private long[] seg = new long[4 * (int)N];
    private readonly long[] segsq = new long[4 * (int)N];
    private readonly long[] lazy = new long[4 * (int)N];

    // Build the segment tree.
    private void Build(int node, long start, long end)
    {
        if (start == end)
        {
            seg[node] = a[(int)start];
            segsq[node] = a[(int)start] * a[(int)start] % hell;
            return;
        }
        long mid = (start + end) >> 1;
        Build(node << 1, start, mid);
        Build(node << 1 | 1, mid + 1, end);
        seg[node] = (seg[node << 1] + seg[node << 1 | 1]) % hell;
        segsq[node] = (segsq[node << 1] + segsq[node << 1 | 1]) % hell;
    }

    // Update the segment tree and handle lazy propagation.
    private void Update(int node, long start, long end, int l, int r, int val)
    {
        if (lazy[node] != 0)
        {
            segsq[node] += (end - start + 1) * lazy[node] * lazy[node] % hell % hell + 2 * lazy[node] * seg[node] % hell;
            segsq[node] %= hell;
            seg[node] += (end - start + 1) * lazy[node] % hell;
            seg[node] %= hell;
            if (start != end)
            {
                lazy[node << 1] += lazy[node];
                lazy[node << 1 | 1] += lazy[node];
            }
            lazy[node] = 0;
        }
        if (start > end || start > r || end < l) return;
        if (l <= start && end <= r)
        {
            segsq[node] += (end - start + 1) * (val * val) % hell % hell + (2 * val * seg[node]) % hell;
            segsq[node] %= hell;
            seg[node] += (end - start + 1) * val % hell;
            seg[node] %= hell;
            if (start != end)
            {
                lazy[node << 1] += val;
                lazy[node << 1 | 1] += val;
            }
            return;
        }
        long mid = (start + end) >> 1;
        Update(node << 1, start, mid, l, r, val);
        Update(node << 1 | 1, mid + 1, end, l, r, val);
        seg[node] = (seg[node << 1] + seg[node << 1 | 1]) % hell;
        segsq[node] = (segsq[node << 1] + segsq[node << 1 | 1]) % hell;
    }

    // Main function to find the sum of counts.
    public int SumCounts(int[] nums)
    {
        seg = new long[4 * (int)N];

        int n = nums.Length;
        for (int i = 1; i <= n; i++)
        {
            a[i] = 0;
        }

        // Build the segment tree.
        Build(1, 1, n);

        Dictionary<int, int> prev_seen_at = new();

        long ans = 0;

        for (int i = n - 1; i >= 0; i--)
        {
            if (!prev_seen_at.ContainsKey(nums[i]))
            {
                Update(1, 1, n, i + 1, n, 1);
            }
            else
            {
                Update(1, 1, n, i + 1, prev_seen_at[nums[i]] - 1, 1);
            }

            prev_seen_at[nums[i]] = i + 1;

            ans = (ans + segsq[1]) % hell;
        }

        return (int)ans;
    }
}
