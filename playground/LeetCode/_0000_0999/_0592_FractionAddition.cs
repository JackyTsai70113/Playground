namespace playground.LeetCode._0000_0999;

public class _0592_FractionAddition
{
    public static string FractionAddition(string expression)
    {
        (long num, long deno) = Helper(expression, 0);
        return $"{num}/{deno}";
    }

    public static (long num, long deno) Helper(string exp, int start)
    {

        if (start == exp.Length)
            return (0, 1);
        int idx = exp.IndexOf('/', start);
        int leftNum = int.Parse(exp[start..idx]);
        int a = exp.IndexOf('+', idx);
        a = a == -1 ? exp.Length : a;
        int b = exp.IndexOf('-', idx);
        b = b == -1 ? exp.Length : b;
        int idx2 = Math.Min(a, b);
        long leftDeno = int.Parse(exp[(idx + 1)..idx2]);
        (long rightNum, long rightDeno) = Helper(exp, idx2);
        long num = leftNum * rightDeno + rightNum * leftDeno;
        long deno = leftDeno * rightDeno;
        if (num == 0)
            return (0, 1);
        for (int i = 2; i * i <= Math.Min(Math.Abs(num), deno); i++)
        {
            while (num % i == 0 && deno % i == 0)
            {
                num /= i;
                deno /= i;
            }
        }
        return (num, deno);
    }
}
