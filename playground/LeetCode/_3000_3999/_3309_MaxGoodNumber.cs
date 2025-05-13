namespace playground.LeetCode._3000_3999;

public class _3309_MaxGoodNumber
{
    public static int MaxGoodNumber(int[] nums)
    {
        string[] binaryStrings = nums.Select(x => Convert.ToString(x, 2)).ToArray();

        Array.Sort(binaryStrings, (a, b) => (b + a).CompareTo(a + b));

        string maxBinaryString = string.Join("", binaryStrings);

        return Convert.ToInt32(maxBinaryString, 2);
    }
}
