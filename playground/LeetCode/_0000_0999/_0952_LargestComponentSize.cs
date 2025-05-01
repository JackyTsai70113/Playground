namespace playground.LeetCode._0000_0999;

public class _0952_LargestComponentSize
{
    public static int LargestComponentSize(int[] nums)
    {
        int n = nums.Max() + 1;
        var isPrime = new bool[n];
        Array.Fill(isPrime, true);
        for (int i = 2; i < n; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * 2; j < n; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        var ds = new DisjointSet(n);
        var res = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int group;
            if (isPrime[nums[i]])
            {
                group = ds.Find(nums[i]);
            }
            else
            {
                int minPrime = -1;
                for (int j = 2; j <= nums[i]; j++)
                {
                    if (isPrime[j] && nums[i] % j == 0)
                    {
                        if (minPrime == -1)
                            minPrime = j;
                        else
                            ds.Union(minPrime, j);
                        while (nums[i] % j == 0)
                        {
                            nums[i] /= j;
                        }
                    }
                }
                group = ds.Find(minPrime);
            }
            ds.Ranks[group]++;
            res = Math.Max(res, ds.Ranks[group]);
        }
        return res;
    }

    public class DisjointSet
    {
        public readonly int[] Groups;
        public readonly int[] Ranks;
        public DisjointSet(int n)
        {
            Groups = Enumerable.Range(0, n).ToArray();
            Ranks = Enumerable.Repeat(0, n).ToArray();
        }
        public int Find(int node)
        {
            if (node != Groups[node])
                Groups[node] = Find(Groups[node]);
            return Groups[node];
        }
        public bool Union(int node1, int node2)
        {
            int group1 = Find(node1);
            int group2 = Find(node2);
            if (group1 == group2)
                return false;
            Groups[group2] = group1;
            Ranks[group1] += Ranks[group2];
            return true;
        }
    }
}
