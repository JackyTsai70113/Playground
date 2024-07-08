namespace playground;

public class NumWaterBottles1518
{
    /// <summary>
    /// https://leetcode.com/problems/water-bottles
    /// </summary>
    public static int NumWaterBottles(int numBottles, int numExchange)
    {
        var res = numBottles;
        while (numBottles >= numExchange)
        {
            res += numBottles / numExchange;
            numBottles = numBottles / numExchange + numBottles % numExchange;
        }
        return res;
    }
}
