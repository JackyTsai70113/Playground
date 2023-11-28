namespace playground.BinarySearch;

public class BinarySearchTemplateClass
{
    /// <summary>
    /// 取左極值
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="l">左邊界</param>
    /// <param name="r">右邊界(要比搜尋範圍多1)</param>
    /// <param name="func"></param>
    /// <returns></returns>
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
    /// 取右極值
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="l">左邊界(要比搜尋範圍少1)</param>
    /// <param name="r">右邊界</param>
    /// <param name="func"></param>
    /// <returns></returns>
    public static int GetUpperBound(int[] arr, int l, int r, Func<int, bool> func)
    {
        while (l < r)
        {
            int m = l + (r - l + 1) / 2;
            if (func(arr[m]))
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

    /// <summary>
    /// 取得 arr 中大於等於 target 的最右index
    /// </summary>
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
