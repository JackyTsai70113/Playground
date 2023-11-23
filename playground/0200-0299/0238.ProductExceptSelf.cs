namespace playground;

public class ProductExceptSelf_0238
{
    public static int[] ProductExceptSelf(int[] nums)
    {
        int zeroCount = 0, product = 1;
        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] == 0)
                zeroCount++;
            else product *= nums[i];
        }
        var res = new int[nums.Length];
        if (zeroCount >= 2)
            return res;
        for (int i = 0; i < nums.Length; i++)
        {
            if (zeroCount == 1)
            {
                if (nums[i] == 0)
                    res[i] = product;
                else
                    res[i] = 0;
            }
            else
            {
                res[i] = product / nums[i];
            }
        }
        return res;
    }

    public static int[] ProductExceptSelf2(int[] nums)
    {
        int n = nums.Length;
        var res = new int[n];
        res[0] = 1;
        for (int i = 1; i < n; ++i)
        {
            res[i] = res[i - 1] * nums[i - 1];
        }
        for (int i = n - 1, right = 1; i >= 0; --i)
        {
            res[i] *= right;
            right *= nums[i];
        }
        return res;
    }
}
