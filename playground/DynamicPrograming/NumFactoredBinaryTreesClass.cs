namespace playground.DynamicPrograming;

public class NumFactoredBinaryTreesClass
{
    public static int NumFactoredBinaryTrees(int[] arr)
    {
        int n = arr.Length, MOD = (int)(1e9 + 7), res = 0;
        Array.Sort(arr);
        var memo = new Dictionary<int, long>();
        for (int i = 0; i < n; ++i)
        {
            memo[arr[i]] = 1;
            for (int j = 0; j <= i; j++)
            {
                if (arr[i] % arr[j] == 0 && memo.ContainsKey(arr[i] / arr[j]))
                {
                    memo[arr[i]] = (memo[arr[i]] + memo[arr[j]] * memo[arr[i] / arr[j]]) % MOD;
                }
            }
            res = (res + (int)memo[arr[i]]) % MOD;
        }
        return res;
    }
}
