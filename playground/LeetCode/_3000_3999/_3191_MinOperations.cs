namespace playground._3100_3199;

public class _3191_MinOperations
{
    public static int MinOperations(int[] nums)
    {
        var change = new bool[3];
        var res = 0;
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if ((nums[i] == 0) ^ change[0])
            {
                res++;
                change[1] = !change[1];
                change[2] = !change[2];
            }
            change[0] = change[1];
            change[1] = change[2];
            change[2] = false;
        }
        if (((nums[^2] == 1) ^ change[0]) && ((nums[^1] == 1) ^ change[1]))
            return res;
        return -1;
    }
}
