namespace playground.LeetCode._2000_2999;

public class _2825_CanMakeSubsequence_cs
{
    public static bool CanMakeSubsequence(string str1, string str2)
    {
        return Dfs(str1, str2, 0, 0);
    }

    public static bool Dfs(string str1, string str2, int i, int j)
    {
        if (j == str2.Length)
        {
            return true;
        }
        if (i == str1.Length)
        {
            return false;
        }
        if (str1[i] == str2[j] || str1[i] + 1 == str2[j] || str1[i] == 'z' && str2[j] == 'a')
        {
            return Dfs(str1, str2, i + 1, j + 1);
        }
        else
        {
            return Dfs(str1, str2, i + 1, j);
        }
    }
}
