namespace playground.DynamicPrograming;

public class CountVowelPermutationClass
{
    /// <summary>
    /// https://leetcode.com/problems/count-vowels-permutation
    /// </summary>
    public static int CountVowelPermutation(int n)
    {
        int MOD = (int)(1e9 + 7);
        var memo = new long[5];
        Array.Fill(memo, 1);
        for (int i = 1; i < n; ++i)
        {
            var memo2 = new long[5];
            memo2[0] = (memo[1] + memo[2] + memo[4]) % MOD;
            memo2[1] = (memo[0] + memo[2]) % MOD;
            memo2[2] = (memo[1] + memo[3]) % MOD;
            memo2[3] = memo[2];
            memo2[4] = (memo[2] + memo[3]) % MOD;
            memo = memo2;
        }
        var res = 0;
        for (int i = 0; i < 5; ++i)
        {
            res = (res + (int)memo[i]) % MOD;
        }
        return res;
    }
}
