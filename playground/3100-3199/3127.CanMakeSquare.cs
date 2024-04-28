namespace playground;

public class CanMakeSquare3127
{
    /// <summary>
    /// https://leetcode.com/problems/make-a-square-with-the-same-color
    /// </summary>
    public static bool CanMakeSquare(char[][] A)
    {
        for (int i = 0; i <= 1; i++)
        {
            for (int j = 0; j <= 1; j++)
            {
                int b = 0;
                for (int k = i; k <= i + 1; k++)
                {
                    for (int l = j; l <= j + 1; l++)
                    {
                        if (A[k][l] == 'B') b++;
                    }
                }
                if (b != 2) return true;
            }
        }
        return false;
    }
}
