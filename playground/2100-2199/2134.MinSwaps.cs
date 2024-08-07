namespace playground;

public class MinSwaps2134
{
    public static int MinSwaps(int[] nums)
    {
        int n = nums.Length, zero1 = 0, one1 = 0;
        int min = n, zero2 = 0, one2 = 0;
        for (int i = 0; i <= n - 1; i++)
        {
            if (nums[i] == 0)
            {
                zero1++;
            }
            else
            {
                one1++;
            }
            if (nums[^(i + 1)] == 0)
            {
                zero2++;
            }
            else
            {
                one2++;
            }
            Console.WriteLine(zero1 + " " + one1 + " " + zero2 + " " + one2);
            if (zero1 == one2)
                min = Math.Min(min, zero1);
            else if (zero2 == one1)
                min = Math.Min(min, zero2);
        }
        return min;
    }
}
