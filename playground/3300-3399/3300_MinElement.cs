namespace playground._3300_3399;

public class _3300_MinElement
{
    public static int MinElement(int[] nums)
    {
        var res = int.MaxValue;
        foreach (var num in nums)
        {
            var cur = num;
            var temp = 0;
            while (cur > 0)
            {
                temp += cur % 10;
                cur /= 10;
            }
            res = Math.Min(res, temp);
        }
        return res;
    }
}
