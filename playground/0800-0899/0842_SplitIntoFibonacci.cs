namespace playground._0800_0899;

public class _0842_SplitIntoFibonacci
{
    public static IList<int> SplitIntoFibonacci(string num)
    {
        var res = new List<int>();
        if (Dfs(num, 0, res))
            return res;
        else
            return Array.Empty<int>();
    }

    public static bool Dfs(string num, int start, List<int> res)
    {
        if (start == num.Length && res.Count >= 3)
            return true;
        long cur = 0;
        for (int i = start; i < num.Length; i++)
        {
            cur = cur * 10 + num[i] - '0';
            if (cur <= int.MaxValue && (res.Count <= 1 || cur == res[^2] + res[^1]))
            {
                res.Add((int)cur);
                if (Dfs(num, i + 1, res))
                    return true;
                res.RemoveAt(res.Count - 1);
            }
            if (i == start && num[i] == '0' || res.Count >= 2 && cur > res[^2] + res[^1])
                break;
        }
        return false;
    }
}
