namespace playground;

public class BinarySearch2
{
    /// <summary>
    /// 取左極值
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <param name="func"></param>
    /// <returns></returns>
    public static int GetLowerBound(int left, int right, Func<int, bool> func)
    {
        int l = left, r = right; // 右邊界要比搜尋範圍多1
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (func(m))
                r = m;
            else
                l = m + 1;
        }
        return l;
    }

    /// <summary>
    /// 取右極值
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="func"></param>
    /// <returns></returns>
    public static int GetUpperBound(int left, int right, Func<int, bool> func)
    {
        int l = left, r = right; // 左邊界要比搜尋範圍少1
        while (l < r)
        {
            int m = l + (r - l + 1) / 2;
            if (func(m))
                l = m;
            else
                r = m - 1;
        }
        return l;
    }
}
