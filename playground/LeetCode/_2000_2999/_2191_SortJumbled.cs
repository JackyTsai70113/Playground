namespace playground.LeetCode._2000_2999;

public class _2191_SortJumbled
{
    public static int[] SortJumbled(int[] mapping, int[] nums)
    {
        List<(int newNum, int oldNum)> items = new();
        int oldNum, newNum, power;
        foreach (var num in nums)
        {
            if (num == 0)
            {
                items.Add((mapping[0], 0));
                continue;
            }
            newNum = 0;
            oldNum = num;
            power = 1;
            for (int i = 0; oldNum > 0; i++)
            {
                newNum += mapping[oldNum % 10] * power;
                power *= 10;
                oldNum /= 10;
            }
            items.Add((newNum, num));
        }
        return items.OrderBy(x => x.newNum).Select(x => x.oldNum).ToArray();
    }
}
