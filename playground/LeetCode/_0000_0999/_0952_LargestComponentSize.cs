using playground.Helpers;

namespace playground.LeetCode._0000_0999;

public class _0952_LargestComponentSize
{
    public static int LargestComponentSize(int[] nums)
    {
        int n = nums.Max();
        var isPrime = MathHelper.GetPrimesSieve(n);

        var ds = new DisjointSet(n + 1);
        foreach (int num in nums)
        {
            if (num == 1) continue;

            int currentNum = num;

            for (int i = 2; i * i <= currentNum; i++)
            {
                if (isPrime[i] && currentNum % i == 0)
                {
                    ds.Union(num, i);
                    while (currentNum % i == 0)
                    {
                        currentNum /= i;
                    }
                }
            }
            if (currentNum > 1)
            {
                ds.Union(num, currentNum);
            }
        }

        Dictionary<int, int> componentSizes = new();
        int maxComponentSize = 0;

        foreach (int num in nums)
        {
            int root = ds.Find(num);

            if (!componentSizes.ContainsKey(root))
            {
                componentSizes[root] = 0;
            }
            componentSizes[root]++;

            maxComponentSize = Math.Max(maxComponentSize, componentSizes[root]);
        }

        return maxComponentSize;
    }
}
