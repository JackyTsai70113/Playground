namespace playground.Mathematics;

public class DifferenceOfSumClass
{
    /// <summary>
    /// https://leetcode.com/problems/difference-between-element-sum-and-digit-sum-of-an-array
    /// </summary>
    public static int DifferenceOfSum(int[] nums)
    {
        int a = 0, b = 0;
        foreach (var num in nums)
        {
            a += num;
            int temp = num;
            while (temp > 0)
            {
                b += temp % 10;
                temp /= 10;
            }
        }
        return Math.Abs(a - b);
    }
}
