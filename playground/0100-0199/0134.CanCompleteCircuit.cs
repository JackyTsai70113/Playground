namespace playground;

public class CanCompleteCircuit_0134
{
    /// <summary>
    /// https://leetcode.com/problems/gas-station
    /// </summary>
    public static int CanCompleteCircuit(int[] gas, int[] cost)
    {
        int start = gas.Length - 1, end = 0;
        int sum = gas[start] - cost[start];
        while (start > end)
        {
            if (sum > 0 )
            {
                sum += gas[end] - cost[end];
                end++;
            }
            else
            {
                start--;
                sum += gas[start] - cost[start];
            }
        }
        return sum < 0 ? -1 : start;
    }
}
