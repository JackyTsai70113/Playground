namespace playground._3400_3499;

public class _3412_CalculateScore
{
    public static long CalculateScore(string s)
    {
        long res = 0;
        var chs = new Stack<int>[26];
        var mark = new bool[s.Length];
        for (int i = 0; i < 26; i++)
        {
            chs[i] = new();
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (chs[25 - s[i] + 'a'].Count > 0)
            {
                var j = chs[25 - s[i] + 'a'].Pop();
                res += i - j;
            }
            else
            {
                chs[s[i] - 'a'].Push(i);
            }
        }
        return res;
    }
}
