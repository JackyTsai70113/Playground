namespace playground._1500_1599;

public class _1574_FindLengthOfShortestSubarray
{
    public static int FindLengthOfShortestSubarray(int[] arr)
    {
        int n = arr.Length, left = 0, right = n - 1;
        while (left + 1 < n && arr[left] <= arr[left + 1])
            left++;
        if (left == n - 1) return 0;

        while (arr[right - 1] <= arr[right])
            right--;
        int res = Math.Min(n - 1 - left, right);
        int i = 0, j = right;
        while (i <= left && j < n)
        {
            if (arr[i] <= arr[j])
            {
                res = Math.Min(res, j - i - 1);
                i++;
            }
            else
            {
                j++;
            }
        }
        return res;
    }
}
