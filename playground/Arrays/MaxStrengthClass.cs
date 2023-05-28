namespace playground.Arrays;

public class MaxStrengthClass
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-strength-of-a-group
    /// </summary>
    public static long MaxStrength(int[] nums)
    {
        long pos = long.MinValue, neg = long.MinValue, maxNeg = long.MinValue;
        int negCount = 0;
        var hasZero = false;
        foreach (var num in nums)
        {
            if (num > 0)
            {
                if (pos == long.MinValue) pos = num;
                else pos *= num;
            }
            else if (num < 0)
            {
                negCount++;
                maxNeg = Math.Max(maxNeg, num);
                if (neg == long.MinValue) neg = num;
                else neg *= num;
            }
            else
            {
                hasZero = true;
            }
        }
        if (pos != long.MinValue && neg != long.MinValue)
        {
            return pos * (neg < 0 ? neg / maxNeg : neg);
        }
        else if (pos != long.MinValue)
        {
            return pos;
        }
        else if (neg != long.MinValue && negCount > 1)
        {
            return neg < 0 ? neg / maxNeg : neg;
        }
        else if (hasZero)
        {
            return 0;
        }
        else
        {
            return maxNeg;
        }
    }
}
