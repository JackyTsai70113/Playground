namespace playground;

public class _3240_MinFlips
{
    public static int MinFlips(int[][] A)
    {
        return FourWay(A) + Middle(A);
    }

    static int FourWay(int[][] A)
    {
        int m = A.Length, n = A[0].Length, res = 0;
        for (int i = 0; i < m / 2; i++)
        {
            for (int j = 0; j < n / 2; j++)
            {
                int count =
                    A[i][j] + A[i][^(j + 1)] +
                    A[^(i + 1)][j] + A[^(i + 1)][^(j + 1)];
                if (count == 1)
                    res++;
                else if (count == 2)
                    res += 2;
                if (count == 3)
                    res++;
            }
        }
        return res;
    }

    static int Middle(int[][] A)
    {
        int m = A.Length, n = A[0].Length;
        int res = 0, ones = 0, twos = 0;
        if (m % 2 == 1)
        {
            for (int j = 0; j < n / 2; j++)
            {
                int count = A[m / 2][j] + A[m / 2][^(j + 1)];
                if (count == 1) ones++;
                if (count == 2) twos++;
            }
        }
        if (n % 2 == 1)
        {
            for (int i = 0; i < m / 2; i++)
            {
                int count = A[i][n / 2] + A[^(i + 1)][n / 2];
                if (count == 1) ones++;
                if (count == 2) twos++;
            }
            if (m % 2 == 1 && A[m / 2][n / 2] == 1)
                res++;
        }
        if (twos % 2 == 1 && ones == 0)
            return res + 2;
        else
            return res += ones;
    }
}
