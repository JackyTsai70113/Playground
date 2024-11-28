namespace playground._1800_1899;

public class _1861_RotateTheBox
{
    public static char[][] RotateTheBox(char[][] box)
    {
        int m = box.Length, n = box[0].Length; // 1, 3
        var res = new char[n][];
        for (int i = 0; i < n; i++)
        {
            res[i] = new char[m];
            for (int j = 0; j < m; j++)
            {
                res[i][m - 1 - j] = box[j][i];
            }
        }
        for (int i = 0; i < m; i++)
        {
            int emptyIndex = n - 1;
            for (int j = n - 1; j >= 0; j--)
            {
                if (res[j][i] == '#')
                {
                    while (res[emptyIndex][i] == '*')
                    {
                        emptyIndex--;
                    }
                    (res[emptyIndex][i], res[j][i]) = (res[j][i], res[emptyIndex][i]);
                    emptyIndex--;
                }
                else if (res[j][i] == '*')
                {
                    emptyIndex = j;
                }
            }
        }
        return res;
    }
}
