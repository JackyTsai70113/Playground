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
        // Calculate the total length of the string
        int n = input.Length;

        // Group characters by frequency
        var frequencies = input.GroupBy(c => c).Select(g => g.Count());

        // Calculate n! (factorial of total length)
        long numerator = Factorial(n);

        // Calculate the product of factorials of frequencies
        long denominator = frequencies.Aggregate(1L, (acc, freq) => acc * Factorial(freq));

        // Return the result of n! / (n1! * n2! * ... * nk!)
        return numerator / denominator;
    }

    public static string GetKthPermutation(string input, long k)
    {
        // Check if the input can form a palindrome
        var charCounts = input.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        if (charCounts.Count(kv => kv.Value % 2 != 0) > 1)
        {
            throw new ArgumentException("Input string cannot form a palindrome.");
        }

        // Build the half string and identify the middle character if any
        var half = new StringBuilder();
        char? middleChar = null;
        foreach (var (key, value) in charCounts)
        {
            if (value % 2 != 0)
            {
                middleChar = key;
            }
            half.Append(key, value / 2);
        }

        // Get the k-th permutation of the half string
        var halfPermutation = GetKthPermutationUnique(half.ToString(), k);

        // Construct the full palindrome
        return middleChar.HasValue
            ? halfPermutation + middleChar + new string(halfPermutation.Reverse().ToArray())
            : halfPermutation + new string(halfPermutation.Reverse().ToArray());
    }

    public static string KthPalindromicPermutation(string s, long k)
    {
        // Check if the input can form a palindrome
        var charCounts = s.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        if (charCounts.Count(kv => kv.Value % 2 != 0) > 1)
        {
            return ""; // Cannot form a palindrome
        }

        // Build the half string and identify the middle character if any
        var half = new StringBuilder();
        char? middleChar = null;
        foreach (var (key, value) in charCounts)
        {
            if (value % 2 != 0)
            {
                middleChar = key;
            }
            half.Append(key, value / 2);
        }

        // Calculate the number of distinct permutations of the half string
        long totalPermutations = GetPermutationCount(half.ToString());
        if (k > totalPermutations)
        {
            return ""; // k exceeds the number of distinct palindromic permutations
        }

        // Get the k-th permutation of the half string
        var halfPermutation = GetKthPermutationUnique(half.ToString(), k);

        // Construct the full palindrome
        return middleChar.HasValue
            ? halfPermutation + middleChar + new string(halfPermutation.Reverse().ToArray())
            : halfPermutation + new string(halfPermutation.Reverse().ToArray());
    }

    private static string GetKthPermutationUnique(string input, long k)
    {
        var characters = input.OrderBy(c => c).ToList();
        var factorials = Factorials(characters.Count);
        k--;

        var result = new StringBuilder();
        for (int i = characters.Count; i > 0; i--)
        {
            int index = (int)(k / factorials[i - 1]);
            result.Append(characters[index]);
            characters.RemoveAt(index);
            k %= factorials[i - 1];
        }

        return result.ToString();
    }

    /// <summary>
    /// 取得階層
    /// </summary>
    public static long Factorial(int num)
    {
        if (num <= 1) return 1;
        return num * Factorial(num - 1);
    }

    /// <summary>
    /// 取得階層列表
    /// </summary>
    public static long[] Factorials(int n)
    {
        var factorials = new long[n + 1];
        factorials[0] = factorials[1] = 1;
        if (n <= 1)
        {
            return factorials;
        }
        for (int i = 2; i <= n; i++)
        {
            factorials[i] = i * factorials[i - 1];
        }
        return factorials;
    }
}