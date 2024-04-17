namespace playground;

public class MonkeyMove2550
{
    /// <summary>
    /// https://leetcode.com/problems/count-collisions-of-monkeys-on-a-polygon
    /// </summary>
    public static int MonkeyMove(int n)
    {
        int MOD = (int)1e9 + 7;
        return (int)((MyPow(2, n, MOD) + MOD - 2) % MOD);
    }

    private static long MyPow(long number, long power, long MOD)
    {
        if (power == 1) return number % MOD;
        if (power % 2 == 0)
            return MyPow(number * number % MOD, power / 2, MOD) % MOD;
        else
            return MyPow(number * number % MOD, power / 2, MOD) % MOD * number % MOD;
    }
}
