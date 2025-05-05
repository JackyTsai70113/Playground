namespace playground.LeetCode._1000_1999;

public class _1710_MaximumUnits
{
    public static int MaximumUnits(int[][] boxTypes, int truckSize)
    {
        Array.Sort(boxTypes, (a, b) => b[1] - a[1]);

        int res = 0;
        for (int i = 0; i < boxTypes.Length; i++)
        {
            if (truckSize == 0)
                break;
            int count = Math.Min(boxTypes[i][0], truckSize);
            res += count * boxTypes[i][1];
            truckSize -= count;
        }
        return res;
    }
}
