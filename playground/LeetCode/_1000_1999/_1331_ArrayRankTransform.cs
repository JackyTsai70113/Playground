namespace playground._1300_1399;

public class _1331_ArrayRankTransform_cs
{
    public static int[] ArrayRankTransform(int[] arr)
    {
        var sortedArray = new int[arr.Length];
        arr.CopyTo(sortedArray, 0);
        Array.Sort(sortedArray);

        var d = new Dictionary<int, int>();
        foreach (var num in sortedArray)
        {
            if (!d.ContainsKey(num))
                d[num] = d.Count + 1;
        }

        var res = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
            res[i] = d[arr[i]];
        return res;
    }
}
