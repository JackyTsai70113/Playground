namespace playground;

public class _1221_BalancedStringSplit
{
    public static int BalancedStringSplit(string s)
    {
        int count = 0, res = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'L')
                count++;
            else
                count--;
            if (count == 0)
                res++;
        }
        return res;
    }
}
