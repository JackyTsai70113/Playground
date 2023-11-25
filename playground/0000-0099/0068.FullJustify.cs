using System.Text;

namespace playground;

public class FullJustify_0068
{
    public static IList<string> FullJustify(string[] A, int maxWidth)
    {
        var res = new List<string>();
        var sbs = new List<StringBuilder>();
        int lineCount = 0;
        for (int i = 0; i < A.Length; ++i)
        {
            if (lineCount + sbs.Count + A[i].Length > maxWidth)
            {
                for (int j = 0; j < maxWidth - lineCount; ++j)
                {
                    if (sbs.Count == 1)
                        sbs[0].Append(' ');
                    else
                        sbs[(j % (sbs.Count - 1))].Append(' ');
                }
                res.Add(string.Join("", sbs));
                sbs = new();
                lineCount = 0;
            }
            sbs.Add(new StringBuilder(A[i]));
            lineCount += A[i].Length;
        }
        res.Add(string.Join(' ', sbs).PadRight(maxWidth));
        return res;
    }
}
