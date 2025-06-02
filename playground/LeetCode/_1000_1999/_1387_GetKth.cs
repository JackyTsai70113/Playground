namespace playground.LeetCode._1000_1999;

public class _1387_GetKth
{
    public static int GetKth(int lo, int hi, int k)
    {
        var result = new (int power, int i)[hi - lo + 1];
        var memo = new Dictionary<int, int>();
        int Dfs(int x)
        {
            if (x == 1) return 0;
            if (memo.ContainsKey(x)) return memo[x];
            int next = x % 2 == 0 ? x / 2 : x * 3 + 1;
            return memo[x] = 1 + Dfs(next);
        }

        for (int i = lo; i <= hi; i++)
        {
            result[i - lo] = (Dfs(i), i);
        }
        Array.Sort(result, (x, y) => x.power != y.power ? x.power - y.power : x.i - y.i);
        return result[k - 1].i;
    }
}
