namespace playground;

public class Cut_f638
{
    /// <summary>
    /// https://zerojudge.tw/ShowProblem?problemid=f638
    /// </summary>
    public static int Cut(int n, int k, int[] nums)
    {
        return Cut(n, k, nums, 0, n - 1);
    }
    /*
                    0  1  2  3  4  5
    nums[i]      :  5  3  4  2  6  2
    prefix[i]    :  5  8 12 14 20 22
    pre_torque[i]:  0  5 13 25 39 59
    suffix[i]    : 22 17 14 10  8  2
    suf_torque[i]: 51 34 20 10  2  0
    torque[i]    : 51 29  7 15 37 59
    */
    static int Cut(int n, int k, int[] nums, int l, int r)
    {
        if (r - l < 2 || k == 0)
            return 0;
        int[] prefix = new int[n], pre_torque = new int[n];
        prefix[l] = nums[l];
        for (int i = l + 1; i <= r; i++)
        {
            prefix[i] = nums[i] + prefix[i - 1];
            pre_torque[i] = prefix[i - 1] + pre_torque[i - 1];
        }

        int[] suffix = new int[n], suf_torque = new int[n];
        suffix[r] = nums[r];
        for (int i = r - 1; i >= l; i--)
        {
            suffix[i] = nums[i] + suffix[i + 1];
            suf_torque[i] = suffix[i + 1] + suf_torque[i + 1];
        }

        int cut_point = l, min_torque = int.MaxValue;
        for (int i = l + 1; i < r; i++)
        {
            var torque = Math.Abs(pre_torque[i] - suf_torque[i]);
            if (min_torque > torque)
            {
                cut_point = i;
                min_torque = torque;
            }
        }

        return nums[cut_point] + Cut(n, k - 1, nums, l, cut_point - 1) + Cut(n, k - 1, nums, cut_point + 1, r);
    }
}
