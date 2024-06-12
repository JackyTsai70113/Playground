namespace playground;

public class MagicalString0481
{
    /// <summary>
    /// https://leetcode.com/problems/magical-string
    /// </summary>
    public static int MagicalString(int n)
    {
        if (n <= 3) return 1;
        int res = 1, tail = 3, num = 1;
        var s = new int[n];
        s[0] = 1; s[1] = 2; s[2] = 2;
        for (int i = 2; tail < n; i++)
        {
            for (int j = 0; j < s[i] && tail < n; j++)
            {
                s[tail++] = num;
                if (num == 1) res++;
            }
            num = num == 1 ? 2 : 1;
        }
        return res;
    }
}
