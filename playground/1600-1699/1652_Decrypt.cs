namespace playground._1600_1699;

public class _1652_Decrypt
{
    public static int[] Decrypt(int[] code, int k)
    {
        int n = code.Length;
        var res = new int[n];
        if (k == 0) return res;
        int dir = k > 0 ? 1 : -1;
        k *= dir;

        int sum = 0;
        for (int i = 1; i <= k; i++)
        {
            sum += code[(n + i * dir) % n];
        }
        res[0] = sum;
        if (dir > 0)
        {
            for (int i = 1; i < n; i++)
            {
                sum += code[(i + k + n) % n] - code[i];
                res[i] = sum;
            }
        }
        else
        {
            for (int i = 1; i < n; i++)
            {
                sum += code[i - 1] - code[(i + n - k - 1) % n];
                res[i] = sum;
            }
        }
        return res;
    }
}
