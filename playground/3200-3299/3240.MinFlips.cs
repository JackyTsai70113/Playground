namespace playground;

public class MinFlips3240
{
    public static int MinFlips(int[][] A)
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
        int middle = 0, oneCount = 0;
        if (m % 2 == 1)
        {
            for (int j = 0; j < n / 2; j++)
            {
                if (A[m / 2][j] != A[m / 2][^(j + 1)])
                    middle++;
                oneCount += A[m / 2][j] + A[m / 2][^(j + 1)];
            }
        }
        if (n % 2 == 1)
        {
            for (int i = 0; i < m / 2; i++)
            {
                if (A[i][n / 2] != A[^(i + 1)][n / 2])
                    middle++;
                oneCount += A[i][n / 2] + A[^(i + 1)][n / 2];
            }
        }
        if (oneCount % 4 == 2)
            res += Math.Max(middle, 2);
        else
            res += middle;
        if (m % 2 == 1 && n % 2 == 1 && A[m / 2][n / 2] == 1)
            res++;
        return res;
    }
}
