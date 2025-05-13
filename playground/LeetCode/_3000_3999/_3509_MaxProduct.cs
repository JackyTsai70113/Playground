namespace playground.LeetCode._3000_3999;

public class _3509_MaxProduct
{
    public static int MaxProduct(int[] nums, int k, int limit)
    {
        int n = nums.Length, res = -1;
        Dictionary<(int, int, int, int), int> memo = new();

        int dfs(int index, int altSum, int product, int parity)
        {
            if (index == n)
            {
                return altSum == k && product <= limit ? product : -1;
            }
            var key = (index, altSum, product, parity);
            if (memo.ContainsKey(key)) return memo[key];

            int max = dfs(index + 1, altSum, product, parity);

            int nextAltSum = (parity == 0 ? nums[index] : -nums[index]) + altSum;
            int nextProduct = Math.Min(product * nums[index], limit + 1);
            max = Math.Max(max, dfs(index + 1, nextAltSum, nextProduct, 1 - parity));
            return memo[key] = max;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            res = Math.Max(res, dfs(i + 1, nums[i], nums[i], 1));
        }
        return res;
    }
}
