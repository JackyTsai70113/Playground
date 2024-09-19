namespace playground;

public class DiffWaysToCompute0241
{
    /// <summary>
    /// https://leetcode.com/problems/different-ways-to-add-parentheses
    /// </summary>
    public static IList<int> DiffWaysToCompute(string expression)
    {
        Dictionary<string, List<int>> memo = new();
        List<int> Dp(string str)
        {
            if (memo.ContainsKey(str))
                return memo[str];
            memo[str] = new();
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                    continue;
                var left = Dp(str[..i]);
                var right = Dp(str[(i + 1)..]);
                foreach (var l in left)
                {
                    foreach (var r in right)
                    {
                        if (str[i] == '+')
                            memo[str].Add(l + r);
                        else if (str[i] == '-')
                            memo[str].Add(l - r);
                        else
                            memo[str].Add(l * r);
                    }
                }
            }

            if (memo[str].Count == 0)
                memo[str].Add(int.Parse(str));
            return memo[str];
        }
        return Dp(expression);
    }
}
