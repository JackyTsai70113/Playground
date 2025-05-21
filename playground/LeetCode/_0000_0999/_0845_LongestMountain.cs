namespace playground.LeetCode._0000_0999;

public class _0845_LongestMountain
{
    public static int LongestMountain_NotOnePass(int[] arr)
    {
        int n = arr.Length, res = 0;
        for (int i = 0; i < n; i++)
        {
            int left = i;

            int mid = left;
            while (mid + 1 < n && arr[mid] < arr[mid + 1])
            {
                mid++;
            }
            if (left == mid) continue;

            int right = mid;
            while (right + 1 < n && arr[right] > arr[right + 1])
            {
                right++;
            }
            if (mid == right) continue;
            res = Math.Max(res, right - left + 1);
        }
        return res;
    }

    public static int LongestMountain_OnePass(int[] arr)
    {
        int res = 0, left = 0, right = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i - 1] == arr[i] || right > 0 && arr[i - 1] < arr[i])
                left = right = 0;
            left += arr[i - 1] < arr[i] ? 1 : 0;
            right += arr[i - 1] > arr[i] ? 1 : 0;
            if (left > 0 && right > 0)
                res = Math.Max(res, left + right + 1);
        }
        return res;
    }
}
