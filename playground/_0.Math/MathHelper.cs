using System.Text;

namespace playground;

public class MathHelper
{
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
        long numerator = factorials[n];

        // Calculate the product of factorials of frequencies
        long denominator = frequencies.Aggregate(1L, (acc, freq) => acc * factorials[freq]);

        // Return the result of n! / (n1! * n2! * ... * nk!)
        return numerator / denominator;
    }

    /// <summary>
    /// 取得階層列表
    /// </summary>
    public static long[] Factorials(int n)
    {
        if (n == 0)
        {
            return new long[] { 1 };
        }
        var factorials = new long[n + 1];
        factorials[0] = factorials[1] = 1;
        for (int i = 2; i <= n; i++)
        {
            factorials[i] = i * factorials[i - 1];
        }
        return factorials;
    }
}