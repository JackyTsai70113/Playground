namespace playground.LeetCode._3000_3999;

public class _3529_CountCells
{
    public static int CountCells(char[][] A, string pattern)
    {
        int m = A.Length, n = A[0].Length;
        var rowKmp = Match(A, pattern, true);
        var colKmp = Match(A, pattern, false);
        int res = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int rowIndex = i * n + j + pattern.Length + 1;
                int colIndex = j * m + i + pattern.Length + 1;
                if (rowKmp[rowIndex] == pattern.Length && colKmp[colIndex] == pattern.Length)
                    res++;
            }
        }
        return res;
    }

    public static int[] Match(char[][] A, string pattern, bool isRow)
    {
        int m = A.Length, n = A[0].Length;
        int total = isRow ? m : n;
        int depth = isRow ? n : m;

        var AA = new char[m * n];
        for (int i = 0, idx = 0; i < total; i++)
        {
            for (int j = 0; j < depth; j++)
            {
                char c = isRow ? A[i][j] : A[j][i];
                AA[idx++] = c;
            }
        }
        var str = pattern + '#' + (new string(AA));
        int[] kmp = KMP(str);
        for (int i = kmp.Length - 1, count = 0; i >= 0; i--)
        {
            if (kmp[i] == pattern.Length)
            {
                count = pattern.Length - 1;
            }
            else if (count > 0)
            {
                kmp[i] = pattern.Length;
                count--;
            }
        }
        return kmp;
    }
    private static int[] KMP(string str)
    {
        int n = str.Length;
        int[] lps = new int[n];
        for (int i = 1, len = 0; i < n; i++)
        {
            while (len > 0 && str[i] != str[len])
                len = lps[len - 1];
            if (str[i] == str[len])
                lps[i] = ++len;
        }
        return lps;
    }
}
