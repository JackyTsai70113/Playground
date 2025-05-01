namespace playground;

public class _3048_EarliestSecondToMarkIndices
{
    /// <summary>
    /// https://leetcode.com/problems/earliest-second-to-mark-indices-i
    /// </summary>
    public static int EarliestSecondToMarkIndices(int[] nums, int[] A)
    {
        int l = 0, r = A.Length;
        while (l < r)
        {
            int mid = l + (r - l) / 2;
            if (IsValid(nums, A, mid))
                r = mid;
            else
                l = mid + 1;
        }
        return l == A.Length ? -1 : l + 1;
    }

    static bool IsValid(int[] nums, int[] A, int m)
    {
        int n = nums.Length;
        var last = new int[n];
        Array.Fill(last, -1);
        for (int i = 0; i <= m; i++)
            last[A[i] - 1] = i;
        int counter = 0, operations = 0;
        for (int i = 0; i <= m; i++)
        {
            if (i == last[A[i] - 1])
            {
                if (operations < nums[A[i] - 1])
                    return false;
                operations -= nums[A[i] - 1];
                counter++;
            }
            else
            {
                operations++;
            }
        }
        return counter == n;
    }
}
