using System.Text;

namespace playground.Backtracking;

public class IsAdditiveNumberClass
{
    public static bool IsAdditiveNumber(string num)
    {
        int n = num.Length;
        for (int i = 1; i < n; ++i)
        {
            for (int j = i + 1; j < n && j + Math.Max(i, j - i) - 1 < n; ++j)
            {
                if (IsAdditive(num, 0, i, j))
                    return true;
            }
        }
        return false;
    }

    private static bool IsAdditive(string num, int a, int b, int c)
    {
        if (c == num.Length)
            return a != 0;
        if (num[a] == '0' && b - a > 1 || num[b] == '0' && c - b > 1)
            return false;
        var sb = new StringBuilder();
        int val = 0, cc = c, bb = b;
        while (c > bb || b > a || val > 0)
        {
            int temp = val + (c > bb ? num[c - 1] - '0' : 0) + (b > a ? num[b - 1] - '0' : 0);
            sb.Insert(0, (char)(temp % 10 + '0'));
            val = temp / 10;
            c--;
            b--;
        }
        var str = sb.ToString();
        if (cc + str.Length - 1 >= num.Length || str != num.Substring(cc, str.Length))
        {
            return false;
        }
        return IsAdditive(num, bb, cc, cc + str.Length);
    }
}
