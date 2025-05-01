namespace playground;

public class _3228_MaxOperations
{
    public static int MaxOperations(string s)
    {
        int count = 0, res = 0;
        var l = new List<int>();
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == '1')
                count++;
            if (s[i] == '1' && s[i + 1] == '0')
            {
                res += count;
            }
        }
        return res;
    }
}
