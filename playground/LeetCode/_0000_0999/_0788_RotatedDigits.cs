namespace playground.LeetCode._0000_0999;

public class _0788_RotatedDigits
{
    public static int RotatedDigits(int n)
    {
        string number = n.ToString();
        int len = number.Length;

        var sameDigits = new HashSet<int> { 0, 1, 8 };
        var diffDigits = new HashSet<int> { 2, 5, 6, 9 };

        var memo = new int[len, 2, 2];
        for (int i = 0; i < len; i++)
            for (int j = 0; j < 2; j++)
                for (int k = 0; k < 2; k++)
                    memo[i, j, k] = -1;

        int Dfs(int index, int isLimitFree, int hasDiff)
        {
            if (index == len)
            {
                return hasDiff == 1 ? 1 : 0;
            }
            if (memo[index, isLimitFree, hasDiff] != -1)
            {
                return memo[index, isLimitFree, hasDiff];
            }

            int res = 0;

            if (isLimitFree == 1)
            {
                res += sameDigits.Count * Dfs(index + 1, 1, hasDiff);
                res += diffDigits.Count * Dfs(index + 1, 1, 1);
            }
            else
            {
                int curDigit = number[index] - '0';
                int sameCount = sameDigits.Count(x => x < curDigit);
                int diffCount = diffDigits.Count(x => x < curDigit);
                res += sameCount * Dfs(index + 1, 1, hasDiff);
                res += diffCount * Dfs(index + 1, 1, 1);
                if (sameDigits.Contains(curDigit))
                {
                    res += Dfs(index + 1, 0, hasDiff);
                }
                else if (diffDigits.Contains(curDigit))
                {
                    res += Dfs(index + 1, 0, 1);
                }
            }
            return memo[index, isLimitFree, hasDiff] = res;
        }
        return Dfs(0, 0, 0);
    }
}
