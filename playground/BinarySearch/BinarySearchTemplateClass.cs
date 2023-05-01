namespace playground.BinarySearch;

public class BinarySearchTemplateClass
{
    public static int GetLowerBound(int[] arr, int target)
    {
        int l = 0, r = arr.Length - 1;
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
