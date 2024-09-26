namespace playground._2000_2099;

public class _2090_GetAverages
{
    public static int[] GetAverages(int[] nums, int k)
    {
        int n = nums.Length;
        int[] res = new int[n];
        Array.Fill(res, -1);
        long sum = 0;
        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            // update state by A[r]
            sum += nums[r];
            if (r >= k * 2)
            {
                res[r - k] = (int)(sum / (k * 2 + 1));
                // update state by A[l]
                sum -= nums[l];
                l++;
            }
        }
        return res;
    }
}
