using System.Numerics;
using System.Text;

namespace playground;

public class Solution
{
    // public static long MinOperations(int[][] qs)
    // {
    //     int n = qs.Length;
    //     long res = 0;
    //     for (int i = 0; i < n; i++)
    //     {
    //         int a = qs[i][0], b = qs[i][1];
    //         int[] count1 = GetCounts(a - 1), count2 = GetCounts(b);
    //         int[] count = new int[9];
    //         for (int j = 0; j < 9; j++)
    //         {
    //             count[j] = count2[j] - count1[j];
    //             Console.Write(count[j] + " ");
    //         }
    //         Console.WriteLine();
    //         // [0, 2, 3] => [0, 4, 1]2 => [0, 4, 0]4
    //         while (count.Select((x, i) => (x, i)).Any(y => y.x > 0 && y.i > 0))
    //         {
    //             int c = 0, d = 0;
    //             for (int j = 8; j >= 1; j--)
    //             {
    //                 if (count[j] > 0)
    //                 {
    //                     if (d == 0)
    //                     {
    //                         d = j;
    //                     }
    //                     else if (c == 0)
    //                     {
    //                         c = j;
    //                         break;
    //                     }
    //                 }
    //             }
    //             if (count[d] > 1)
    //             {
    //                 count[d - 1] += count[d] / 2 * 2;
    //                 count[d] %= 2;
    //                 res += count[d] / 2 * 2;
    //             }
    //             else
    //             {
    //                 count[d] = 0;
    //                 count[d - 1] += 1;
    //                 count[c] -= 1;
    //                 if (c > 0)
    //                     count[c - 1] += 1;
    //                 res += 1;
    //             }
    //         }
    //     }
    //     return res;
    // }

    // public static int[] GetCounts(int r)
    // {
    //     var res = new int[9];
    //     if (r == 0) return res;
    //     for (int i = 1, cur = 4, presum = 0; i < 9; i++)
    //     {
    //         res[i] = Math.Min(r, cur - 1) - presum;
    //         presum += res[i];
    //         cur *= 4;
    //     }
    //     return res;
    // }

    public static string SmallestPalindrome(string s, int k)
    {
        int n = s.Length, nn = n / 2;
        var ddd = MathHelper.Factorials(10000 / 2);
        if (nn == 0)
        {
            return n > 0 ? s[nn].ToString() : "";
        }
        var sorted = s.Substring(0, nn);

        var freq = new Dictionary<char, int>();
        foreach (char c in sorted)
        {
            if (!freq.ContainsKey(c))
                freq[c] = 0;
            freq[c]++;
        }

        var factorial = new long[nn + 1];
        factorial[0] = 1;
        for (int i = 1; i <= nn; i++)
            factorial[i] = factorial[i - 1] * i;

        BigInteger CountPermutations(Dictionary<char, int> f)
        {
            int total = f.Values.Sum();
            long denom = 1;
            foreach (var val in f.Values)
                denom *= factorial[val];
            return factorial[total] / denom;
        }

        if (k > CountPermutations(freq))
        {
            return "";
        }
        var result = new List<char>();
        var uniqueChars = freq.Keys.OrderBy(c => c).ToList();

        while (result.Count < nn)
        {
            foreach (var ch in uniqueChars)
            {
                if (freq[ch] == 0) continue;

                freq[ch]--;
                var count = CountPermutations(freq);

                if (k <= count)
                {
                    result.Add(ch);
                    break;
                }
                else
                {
                    k -= (int)count;
                    freq[ch]++;
                }
            }
        }

        var first = result.ToArray();
        result.Reverse();
        var last = result.ToArray();
        return new string(first) + (n % 2 == 1 ? s[nn] : "") + new string(last);
    }
}
/*
xxnfnxx
nxx
xxn
xxn
\

abc:
abc
acb
bac
bca
cab
cba

acc:
acc
cac
cca

1223:
1223
1232
1322

2123
2132
2213
2231
2312
2321

3122
3212
3221

4*3*2*1/2=12

*/