namespace playground.LeetCode._3000_3999;

public class _3302_ValidSequence
{
    public static int[] ValidSequence(string a, string b)
    {
        int m = a.Length, n = b.Length;
        int i = 0, j = 0;
        int[] res = new int[n];
        bool Valid(int i, int j)
        {
            while (i < a.Length && j < b.Length)
            {
                if (a[i] == b[j])
                    res[j++] = i;
                i++;
            }
            return j == n;
        }
        while (i < m && j < n && a[i] == b[j])
        {
            res[j++] = i++;
        }
        while (i < m && j < n)
        {
            if (Valid(i + 1, j + 1))
            {
                res[j] = i;
                return res;
            }
            while (i < m && j < n)
            {
                if (Valid(i + 1, j + 1))
                {
                    res[j] = i;
                    return res;
                }
                while (i < m && j < n)
                {
                    if (a[i] == b[j])
                    {
                        while (a[i] == b[j])
                        {
                            res[j++] = i++;
                        }
                        break;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
        }
        return j == n ? res : Array.Empty<int>();
    }
}