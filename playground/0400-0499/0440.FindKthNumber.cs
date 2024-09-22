namespace playground;

public class FindKthNumber0440
{

    /// <remarks>https://leetcode.com/problems/k-th-smallest-in-lexicographical-order/solutions/5818066/yes-visualize-the-explanation-in-most-simple-way-beats-100</remarks>
    public static int FindKthNumber(int n, int k)
    {
        k--;
        int cur = 1;
        while (k > 0)
        {
            int step = GetStepCount(n, cur, cur + 1);
            if (step <= k)
            {
                k -= step;
                cur++;
            }
            else
            {
                k--;
                cur *= 10;
            }
        }
        return cur;
    }

    public static int GetStepCount(int n, long tree1, long tree2)
    {
        long step = 0;
        while (tree1 <= n)
        {
            if (n + 1 >= tree2)
            {
                // 15, 1, 2
                step += tree2 - tree1;
            }
            else
            {
                // 15, 10, 20
                step += n + 1 - tree1;
            }
            tree1 *= 10;
            tree2 *= 10;
        }
        return (int)step;
    }
}
