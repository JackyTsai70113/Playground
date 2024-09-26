namespace playground._2200_2299;

public class _2216_MinDeletion
{
    public static int MinDeletion(int[] nums)
    {
        int res = 0;
        bool flag = false;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if ((i & 1) == 0 && nums[i] == nums[i + 1] && !flag)
            {
                res++;
                flag = true;
            }
            else if ((i & 1) == 1 && nums[i] == nums[i + 1] && flag)
            {
                res++;
                flag = false;
            }
        }
        // deleted nums must be even length
        return ((nums.Length - res) & 1) == 1 ?
            res + 1 :
            res;
    }
}
