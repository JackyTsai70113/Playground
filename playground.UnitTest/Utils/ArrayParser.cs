namespace playground.UnitTest.Utils;

public static class ArrayParser
{
    public static T[][] To2dArray<T>(this T[] array, int rowCount)
    {
        if (array.Length % rowCount != 0)
        {
            throw new ArgumentException("invalid array.Length");
        }
        var res = new T[array.Length / rowCount][];
        for (int i = 0; i < res.Length; ++i)
        {
            res[i] = new T[rowCount];
            for (int j = 0; j < rowCount; ++j)
            {
                res[i][j] = array[i * rowCount + j];
            }
        }
        return res;
    }

    public static T[] ToArr<T>(this string str)
    {
        str = str.Trim();
        str = str[1..^1];
        var arr = str.Split(',').Select(x => (T)Convert.ChangeType(x.Trim(), typeof(T))).ToArray();
        return arr;
    }

    public static T[][] To2dArr<T>(this string str)
    {
        str = str.Trim();
        str = str[1..^1];
        int l = 0, r = 0;
        var res = new List<T[]>();
        while (l < str.Length && r < str.Length)
        {
            while (l < str.Length && str[l] != '[') l++;
            while (r < str.Length && str[r] != ']') r++;
            if (l < str.Length)
            {
                var s = str.Substring(l + 1, r - l - 1);
                if (string.IsNullOrWhiteSpace(s))
                {
                    res.Add(Array.Empty<T>());
                    l++;
                    r++;
                    continue;
                }
                var arr = s.Split(',').Select(x => (T)Convert.ChangeType(x.Trim(), typeof(T))).ToArray();
                res.Add(arr);
            }
            l++;
            r++;
        }
        return res.ToArray();
    }
}