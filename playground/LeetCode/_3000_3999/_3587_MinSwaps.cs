namespace playground.LeetCode._3000_3999;

public class _3587_MinSwaps
{
    public static int MinSwaps(int[] nums)
    {
        List<int> evenIndices = new();
        List<int> oddIndices = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                evenIndices.Add(i);
            }
            else
            {
                oddIndices.Add(i);
            }
        }

        if (Math.Abs(evenIndices.Count - oddIndices.Count) > 1)
            return -1;

        int n = nums.Length, oddLen = oddIndices.Count, evenLen = evenIndices.Count;
        long calculate(int parity)
        {
            long swaps = 0;
            if (parity == 0)
            {
                if (evenLen != Math.Ceiling((double)n / 2) ||
                    oddLen != Math.Floor((double)n / 2))
                    return long.MaxValue;
                for (int i = 0; i < evenIndices.Count; i++)
                {
                    swaps += Math.Abs(evenIndices[i] - (2 * i));
                }
                for (int i = 0; i < oddIndices.Count; i++)
                {
                    swaps += Math.Abs(oddIndices[i] - (2 * i + 1));
                }
            }
            else
            {
                if (oddLen != Math.Ceiling((double)n / 2) ||
                    evenLen != Math.Floor((double)n / 2))
                    return int.MaxValue;
                for (int i = 0; i < evenIndices.Count; i++)
                {
                    swaps += Math.Abs(evenIndices[i] - (2 * i + 1));
                }
                for (int i = 0; i < oddIndices.Count; i++)
                {
                    swaps += Math.Abs(oddIndices[i] - (2 * i));
                }
            }
            return swaps / 2;
        }

        long minSwaps = long.MaxValue;
        minSwaps = Math.Min(minSwaps, calculate(0));
        minSwaps = Math.Min(minSwaps, calculate(1));
        return (int)minSwaps;
    }
}