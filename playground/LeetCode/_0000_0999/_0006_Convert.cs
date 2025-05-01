using System.Text;

namespace playground.LeetCode._0000_0999;

public class _0006_Convert
{
    public static string Convert(string s, int numRows)
    {
        if (numRows == 1 || numRows >= s.Length)
            return s;
        var sbs = new StringBuilder[numRows];
        for (int i = 0; i < numRows; ++i)
            sbs[i] = new();
        int j = 0, step = 1;
        foreach (var c in s)
        {
            sbs[j].Append(c);
            if (j == 0) step = 1;
            else if (j == numRows - 1) step = -1;
            j += step;
        }
        return string.Join("", sbs.Select(x => x.ToString()));
    }
}
