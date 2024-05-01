namespace playground;

public class PeakIndexInMountainArray0852
{
    /// <summary>
    /// https://leetcode.com/problems/peak-index-in-a-mountain-array
    /// </summary>
    public static int PeakIndexInMountainArray(int[] arr)
    {
        int l = 0, r = arr.Length - 1;
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (arr[m] > arr[m + 1])
                r = m;
            else
                l = m + 1;
        }
        return l;
    }

    /// <remark>Golden-section search</remark>
    public static int PeakIndexInMountainArray2(int[] arr)
    {
        int gold1(int l, int r) =>
            l + (int)(Math.Round((r - l) * 0.382));
        int gold2(int l, int r) =>
            l + (int)(Math.Round((r - l) * 0.618));
        int l = 0, r = arr.Length - 1;
        int x1 = gold1(l, r), x2 = gold2(l, r);
        while (x1 < x2)
        {
            if (arr[x1] < arr[x2])
            {
                l = x1;
                x1 = x2;
                x2 = gold1(x1, r);
            }
            else
            {
                r = x2;
                x2 = x1;
                x1 = gold2(l, x2);
            }
        }
        return Array.IndexOf(arr, arr.Skip(l - 1).Take(r - l + 1).Max(), l);
    }
}
