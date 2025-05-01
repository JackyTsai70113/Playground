namespace playground._3300_3399;

public class _3318_FindXSum
{
    public static int[] FindXSum(int[] nums, int k, int xx)
    {
        int n = nums.Length;
        var res = new int[n - k + 1];
        var count = new int[51];
        for (int i = 0; i < n; i++)
        {
            count[nums[i]]++;
            if (i >= k - 1)
            {
                List<int[]> l = new();
                for (int j = 0; j < count.Length; j++)
                {
                    if (count[j] > 0)
                        l.Add(new int[] { j, count[j] });
                }
                l.Sort((x, y) =>
                {
                    if (x[1] == y[1])
                        return y[0] - x[0];
                    else
                        return y[1] - x[1];
                });

                int sum = 0;
                for (int j = 0; j < Math.Min(xx, l.Count); j++)
                {
                    sum += l[j][0] * l[j][1];
                }
                res[i - k + 1] = sum;
                count[nums[i - k + 1]]--;
            }
        }
        return res;
    }
}
