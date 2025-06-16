using System.Text.Json;

namespace playground.UnitTest.Utils;

public static class ArrayParser
{
    public static int[] ToArr(this string str)
    {
        return str.ToArr<int>();
    }

    public static T[] ToArr<T>(this string str)
    {
        return JsonSerializer.Deserialize<T[]>(str);
    }

    public static int[][] To2dArr(this string str)
    {
        return str.To2dArr<int>();
    }

    public static T[][] To2dArr<T>(this string str)
    {
        str = str.Replace("\n", "").Replace("\r", "");

        return JsonSerializer.Deserialize<T[][]>(str);
    }
}