namespace playground;

public class _3100_MaxBottlesDrunk
{
    /// <summary>
    /// https://leetcode.com/problems/water-bottles-ii
    /// </summary>
    public static int MaxBottlesDrunk(int numBottles, int numExchange)
    {
        int res = 0, empty = 0;
        while (numBottles > 0)
        {
            res += numBottles;
            empty += numBottles;
            numBottles = 0;
            if (empty >= numExchange)
            {
                numBottles++;
                empty -= numExchange;
                numExchange++;
            }
        }
        return res;
    }
}
