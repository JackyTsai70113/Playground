namespace playground.Helpers;

public class MathHelper
{
    /// <summary>
    /// PowersOfTwo 對照表：Key 為指數 n，Value 為 2^n 的數值。
    /// 用於快速查詢常見的 2 的次方值，適用於演算法、記憶體、資料量估算。
    /// </summary>
    public static readonly Dictionary<int, ulong> PowersOfTwo = new()
    {
        {10, 1024UL},                     // 約 10^3，1KB
        {20, 1_048_576UL},                // 約 10^6，1MB
        {30, 1_073_741_824UL},            // 約 10^9，1GB
        {31, 2_147_483_648UL},            // 超過 int.MaxValue（int 溢位點）
        {32, 4_294_967_296UL},            // uint.MaxValue + 1
        {40, 1_099_511_627_776UL},        // 約 10^12，1TB
        {50, 1_125_899_906_842_624UL},    // 約 10^15，1PB
        {63, 9_223_372_036_854_775_808UL},// 超過 long.MaxValue（long 溢位點）
        // {64, 18_446_744_073_709_551_616UL}// ulong.MaxValue + 1，64-bit 空間極限
    };

    /// <summary>
    /// i 中取 j 個的組合數
    /// </summary>
    /// <remarks>
    /// ex: n=5:<br/>
    /// <br/>
    ///  1 0 0 0 0<br/>
    ///  1 1 0 0 0<br/> 
    ///  1 2 1 0 0<br/>
    ///  1 3 3 1 0<br/>
    ///  1 4 6 4 1<br/>
    /// </remarks>
    public static int[,] GetCombination(int n)
    {
        var combination = new int[n, n];
        for (int i = 0; i < n; ++i)
        {
            combination[i, 0] = 1;
        }
        for (int i = 1; i < n; ++i)
        {
            for (int j = 1; j <= i; ++j)
            {
                // C i 取 j
                combination[i, j] = combination[i - 1, j - 1] + combination[i - 1, j];
            }
        }
        return combination;
    }

    public static long GetPermutationCount(string input)
    {
        if (input == null || input.Length == 0)
            return 1;

        // Calculate the total length of the string
        int n = input.Length;

        // Group characters by frequency
        var frequencies = input.GroupBy(c => c).Select(g => g.Count());

        var factorials = Factorials(n);

        // Calculate n! (factorial of total length)
        long perms = factorials[n];

        foreach (var freq in frequencies)
            perms /= factorials[freq];

        return perms;
    }

    /// <summary>
    /// 取得階層列表
    /// </summary>
    public static long[] Factorials(int n)
    {
        var factorials = new long[n + 1];
        factorials[0] = 1;
        for (int i = 1; i <= n; i++)
        {
            factorials[i] = factorials[i - 1] * i;
        }
        return factorials;
    }

    /// <summary>
    /// 使用埃拉托色尼篩法(Sieve Of Eratosthenes)，找出小於等於 n 的所有質數。
    /// </summary>
    /// <param name="n">範圍上限，找出所有小於等於 n 的質數。</param>
    /// <returns>
    /// 一個布林陣列，其中 isPrime[i] 為 true 表示 i 是質數，false 表示不是。
    /// </returns>
    public static bool[] GetPrimes(int n)
    {
        if (n == 0)
        {
            return new bool[] { false };
        }
        var isPrime = Enumerable.Repeat(true, n + 1).ToArray();
        isPrime[0] = isPrime[1] = false;
        for (int p = 2; p * p <= n; ++p)
        {
            if (!isPrime[p])
                continue;
            for (int i = p * 2; i <= n; i += p)
                isPrime[i] = false;
        }

        return isPrime;
    }

    /// <summary>
    /// Computes an array of powers of 2 modulo MOD.
    /// Returns an array pow2 where pow2[i] = (2^i) % MOD.
    /// </summary>
    /// <param name="n">The length of the array to compute.</param>
    /// <param name="mod">The modulo value. Defaults to 1e9 + 7.</param>
    /// <returns>Array of (2^i) % mod for i from 0 to n-1.</returns>
    public static long[] GetPowersOfTwoMod(int n, long mod = 1_000_000_007)
    {
        var pow2 = new long[n];
        pow2[0] = 1;
        for (int i = 1; i < n; i++)
        {
            pow2[i] = pow2[i - 1] * 2 % mod;
        }
        return pow2;
    }
}