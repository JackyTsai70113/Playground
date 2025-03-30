using System.Numerics;

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
}