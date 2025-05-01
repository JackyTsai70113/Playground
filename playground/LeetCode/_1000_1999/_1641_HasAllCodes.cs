namespace playground._1400_1499;

public class _1641_HasAllCodes_cs
{
    public static bool HasAllCodes(string s, int k)
    {
        var exist = new bool[1 << k];
        int cur = 0, count = 0;
        for (int r = 0; r < s.Length; r++)
        {
            // update state by A[r]
            cur = (cur << 1) | (s[r] - '0');
            if (r >= k - 1)
            {
                // update state by A[l]
                cur &= (1 << k) - 1;
                if (exist[cur] == false)
                {
                    count++;
                    if (count == (1 << k))
                        return true;
                }
                exist[cur] = true;
            }
        }
        return false;
    }
}
