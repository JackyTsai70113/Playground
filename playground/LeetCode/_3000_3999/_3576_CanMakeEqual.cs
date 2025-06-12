namespace playground.LeetCode._3000_3999;

public class _3576_CanMakeEqual
{
    public static bool CanMakeEqual(int[] nums, int k)
    {
        int n = nums.Length;

        bool check(int target)
        {
            int flipCount = 0;
            bool valid = true;
            var flip = new int[n];
            Array.Fill(flip, 1);
            for (int i = 0; i < n - 1; i++)
            {
                if (nums[i] * flip[i] != target)
                {
                    flipCount++;
                    if (flipCount > k)
                    {
                        valid = false;
                        break;
                    }
                    flip[i] *= -1;
                    flip[i + 1] *= -1;
                }
            }
            if (valid && nums[^1] * flip[^1] == target)
                return true;
            return false;
        }

        return check(1) || check(-1);
    }
}
