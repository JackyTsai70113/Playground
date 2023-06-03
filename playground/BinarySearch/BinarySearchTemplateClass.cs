namespace playground.BinarySearch;

public class BinarySearchTemplateClass
{
    public static int ArrayBinarySearch(int[] arr, int target)
    {
        return Array.BinarySearch(arr, target);
    }

    public static int GetLowerBound(int[] arr, int l, int r, Func<int, bool> func)
    {
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (func(arr[m]))
            {
                r = m;
            }
            else
            {
                l = m + 1;
            }
        }
        return l;
    }

    /// <summary>
    /// 取得 arr 中大於等於 target 的最左index
    /// </summary>
    public static int GetLowerBound(int[] arr, int target)
    {
        int l = 0, r = arr.Length;
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (arr[m] >= target)
            {
                r = m;
            }
            else
            {
                l = m + 1;
            }
        }
        return l;
    }

    public static int GetUpperBound(int[] arr, int target)
    {
        int l = 0, r = arr.Length - 1;
        while (l < r)
        {
            int m = l + (r - l + 1) / 2;
            if (arr[m] <= target)
            {
                l = m;
            }
            else
            {
                r = m - 1;
            }
        }
        return l;
    }
}
