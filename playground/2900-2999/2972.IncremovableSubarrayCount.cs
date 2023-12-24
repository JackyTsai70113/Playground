namespace playground;

public class IncremovableSubarrayCount2972
{
    // https://leetcode.com/problems/count-the-number-of-incremovable-subarrays-ii
    public static long IncremovableSubarrayCount(int[] nums)
    {
        int n = nums.Length;
        bool[] left = new bool[n + 2], right = new bool[n + 2];
        left[0] = right[^1] = true;
        var list = new List<int> { 0 };
        list.AddRange(nums);
        list.Add(int.MaxValue);
        for (int i = 1; i < n + 2; ++i)
        {
            if (list[i - 1] < list[i] && left[i - 1])
                left[i] = true;
            else
                break;
        }

        for (int i = n; i >= 0; --i)
        {
            if (list[i] < list[i + 1] && right[i + 1])
                right[i] = true;
            else
                break;
        }
        long res = 0;
        for (int i = 0; i < n && left[i]; ++i)
        {
            int l = i + 2, r = n + 1;
            while (l < r)
            {
                int m = l + (r - l) / 2;
                if (right[m] && list[i] < list[m])
                    r = m;
                else
                    l = m + 1;
            }
            res += n - l + 2;
        }
        return res;
    }
}
