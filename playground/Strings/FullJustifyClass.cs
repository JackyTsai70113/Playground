namespace playground.Strings;

public class FullJustifyClass
{
    /// <summary>
    /// https://leetcode.com/problems/text-justification/
    /// </summary>
    public static IList<string> FullJustify(string[] words, int maxWidth)
    {
        var res = new List<string>();
        var strs = new List<string>();
        foreach (var w in words)
        {
            if (strs.Count == 0)
            {
                strs.Add(w);
                continue;
            }

            var lineLength = strs.Select(s => s.Length).Sum();
            if (lineLength + w.Length < maxWidth)
            {
                strs.Add(" ");
                strs.Add(w);
            }
            else
            {
                int spaceCount = maxWidth - lineLength;
                if (strs.Count == 1)
                {
                    strs.Add(new string(' ', spaceCount));
                }
                else
                {
                    while (spaceCount > 0)
                    {
                        for (int i = 1; i < strs.Count && spaceCount > 0; i += 2)
                        {
                            strs[i] += " ";
                            spaceCount--;
                        }
                    }
                }
                res.Add(string.Join(string.Empty, strs));
                strs = new List<string> { w };
            }
        }
        var lastLineLength = strs.Select(s => s.Length).Sum();
        int lastSpaceCount = maxWidth - lastLineLength;
        strs.Add(new string(' ', lastSpaceCount));
        res.Add(string.Join(string.Empty, strs));
        return res;
    }
}
