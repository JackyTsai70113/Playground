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
    /// 計算組合數 C(n, r)，即「n 個取 r 個」的方式數，支援取模（通常用於大數/競賽）
    /// </summary>
    /// <param name="n">總數 n</param>
    /// <param name="r">取 r 個</param>
    /// <param name="mod">取模基底（通常是質數，例如 1e9+7）</param>
    /// <returns>C(n, r) % mod</returns>
    public static long GetCombination(int n, int r, long mod)
    {
        // if (r < 0 || r > n) return 0;

        // C(n, r) 在 r=0 或 r=n 時為 1
        if (r == 0 || r == n) return 1;
        // 利用 C(n, r) = C(n, n-r) 性質，加速計算
        if (r > n - r) r = n - r;

        long numerator = 1;
        for (int i = 0; i < r; i++)
            numerator = numerator * (n - i) % mod; // 計算分子 n*(n-1)*...*(n-r+1)
        long denominator = 1;
        for (int i = 1; i <= r; i++)
            denominator = denominator * i % mod; // 計算分子 n*(n-1)*...*(n-r+1)

        // 利用費馬小定理，分母取逆元（模質數才有效）
        return numerator * ModInverse(denominator, mod) % mod;
    }

    /// <summary>
    /// 求 n 的模逆元（即 n^(-1) % mod），假設 mod 是質數
    /// </summary>
    /// <param name="n">被取逆的數</param>
    /// <param name="mod">質數模數</param>
    /// <returns>n 在 mod 下的逆元</returns>
    public static long ModInverse(long n, long mod)
    {
        // 費馬小定理：n^(mod-2) % mod
        return Pow(n, mod - 2, mod);
    }

    /// <summary>
    /// 快速冪演算法，計算 (val^exp) % mod
    /// </summary>
    /// <param name="val">底數</param>
    /// <param name="exp">指數</param>
    /// <param name="mod">模數</param>
    /// <returns>(val^exp) % mod</returns>
    public static long Pow(long val, long exp, long mod)
    {
        long res = 1;
        val %= mod;
        while (exp > 0)
        {
            if ((exp & 1) == 1)
                res = res * val % mod;
            val = val * val % mod;
            exp >>= 1;
        }
        return res;
    }

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
    public static int[,] GetCombinations(int n)
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
                // C(i, j) = C(i-1, j-1) + C(i-1, j)
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
    /// <remarks>
    /// #IsPrime
    /// </remarks>
    public static bool[] GetPrimesSieve(int n)
    {
        if (n < 0) return Array.Empty<bool>();
        var isPrime = Enumerable.Repeat(true, n + 1).ToArray();
        if (n >= 0) isPrime[0] = false;
        if (n >= 1) isPrime[1] = false;
        if (n >= 2)
        {
            for (int i = 4; i <= n; i += 2)
            {
                isPrime[i] = false;
            }
        }
        for (int j = 3; j * j <= n; j += 2)
        {
            if (isPrime[j])
            {
                for (int p = j * j; p <= n; p += 2 * j)
                {
                    isPrime[p] = false;
                }
            }
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