namespace playground;

public class Solution
{
    // public int SubsequencesWithMiddleMode(int[] nums)
    // {
    //     int n = nums.Length;
    //     Dictionary<int, int> d = new();
    //     for (int i = 0; i < nums.Length; i++)
    //     {
    //         d[nums[i]] = d.GetValueOrDefault(nums[i]) + 1;
    //     }
    //     Dictionary<int, int> counts = new();
    //     foreach (var kvp in d)
    //     {
    //         var count = kvp.Value;
    //         counts[count] = counts.GetValueOrDefault(count) + 1;
    //     }
    //     var arr = counts
    //         .Select(kvp => (freq: kvp.Key, count: kvp.Value))
    //         .Where(x => x.freq != 1)
    //         .ToArray();
    //     int remain = n;
    //     long res = 0, MOD = (long)1e9 + 7;
    //     for (int i = 0; i < arr.Length; i++)
    //     {
    //         remain
    //     }
    // }

    public static int MinLength(string s, int flipCount)
    {
        int n = s.Length;
        var chs = s.ToCharArray();
        bool Valid(int minLength)
        {
            int n = s.Length;

            // Helper function to check if we can make all substrings for a target character less than or equal to minLength
            bool CanReduce(char targetChar)
            {
                int flips = 0;
                int left = 0;

                for (int right = 0; right < n; right++)
                {
                    if (s[right] != targetChar)
                    {
                        flips++;
                    }

                    // If flips exceed allowed flipCount, move the left pointer
                    while (flips > flipCount)
                    {
                        if (s[left] != targetChar)
                        {
                            flips--;
                        }
                        left++;
                    }

                    // If the current window length is greater than minLength, return false
                    if (right - left + 1 > minLength)
                    {
                        return false;
                    }
                }

                return true;
            }

            // Check for both '0' and '1' as target characters
            return CanReduce('0') && CanReduce('1');
        }

        int l = 1, r = n, res = n;
        while (l <= r)
        {
            int m = l + (r - l) / 2;
            if (Valid(m))
            {
                res = m;
                r = m - 1;
            }
            else
            {
                l = m + 1;
            }
        }
        return res;
    }

    public static int CountPaths(int n, int[][] roads)
    {
        if (n == 1) return 1;
        var g = new List<(int v, long d)>[n];
        for (int i = 0; i < n; i++) g[i] = new();
        foreach (var r in roads)
        {
            g[r[0]].Add((r[1], r[2]));
            g[r[1]].Add((r[0], r[2]));
        }

        var dists = new (long d, long count)[n];
        dists[0] = (0, 1);
        for (int i = 1; i < n; i++)
        {
            dists[i] = (long.MaxValue, 0);
        }

        var pq = new PriorityQueue<int, long>();
        pq.Enqueue(0, dists[0].d);
        long MOD = (long)1e9 + 7;
        while (pq.Count > 0)
        {
            var u = pq.Dequeue();
            if (u == n - 1)
            {
                continue;
            }
            foreach (var (v, d) in g[u])
            {
                if (dists[v].d > dists[u].d + d)
                {
                    dists[v] = (dists[u].d + d, 1);
                    pq.Enqueue(v, dists[v].d);
                }
                else if (dists[v].d == dists[u].d + d)
                {
                    dists[v] = (dists[v].d, (dists[v].count + 1) % MOD);
                }
            }
        }
        return (int)dists[n - 1].count;
    }
}
/*
Console.Write(s + " " + minLength + " " + flipCount + " ");
            Console.WriteLine(false);
            Console.WriteLine(true);
*/