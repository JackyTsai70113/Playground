namespace playground._2700_2799;

public class _2717_SemiOrderedPermutation
{
    public static int SemiOrderedPermutation(int[] nums)
    {
        int l = 0, r = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] == 1)
                l = i;
            else if (nums[i] == nums.Length)
                r = i;
        }
        var res = l + nums.Length - 1 - r;
        return res + (l > r ? -1 : 0);
    }
}
