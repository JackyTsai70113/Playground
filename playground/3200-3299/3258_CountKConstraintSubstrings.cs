namespace playground._3200_3299;

public class _3258_CountKConstraintSubstrings
{
    public static int CountKConstraintSubstrings(string s, int k)
    {
        int zero = 0, one = 0;
        int res = 0;
        bool Valid()
        {
            return zero <= k || one <= k;
        }
        for (int l = 0, r = 0; r < s.Length; r++)
        {
            if (s[r] == '0')
                zero++;
            else
                one++;
            while (!Valid())
            {
                if (s[l] == '0')
                    zero--;
                else
                    one--;
                l++;
            }
            res += r - l + 1;
        }
        return res;
    }
}
