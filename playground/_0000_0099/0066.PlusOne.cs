namespace playground;

public class PlusOne0066
{
    /// <summary>
    /// https://leetcode.com/problems/power-of-three
    /// </summary>
    public static int[] PlusOne(int[] digits)
    {
        var res = new List<int>();
        int carry = 1;
        for (int i = digits.Length - 1; i >= 0; --i)
        {
            var temp = digits[i] + carry;
            res.Insert(0, temp % 10);
            carry = temp / 10;
        }
        if (carry > 0)
            res.Insert(0, 1);
        return res.ToArray();
    }
}
