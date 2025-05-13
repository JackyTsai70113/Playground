using System.Text;

namespace playground.LeetCode._1000_1999;

public class _1405_LongestDiverseString
{
    public static string LongestDiverseString(int a, int b, int c)
    {
        return LongestDiverseString(a, b, c, 'a', 'b', 'c');
    }
    public static string LongestDiverseString(int large, int medium, int small, char largeChar, char mediumChar, char smallChar)
    {
        if (large < medium)
        {
            return LongestDiverseString(medium, large, small, mediumChar, largeChar, smallChar);
        }
        if (medium < small)
        {
            return LongestDiverseString(large, small, medium, largeChar, smallChar, mediumChar);
        }
        if (medium == 0)
        {
            return new string(largeChar, Math.Min(2, large));
        }
        int useLarge = Math.Min(2, large), useMedium = large - useLarge >= medium ? 1 : 0;
        return new string(largeChar, useLarge) +
            new string(mediumChar, useMedium) +
            LongestDiverseString(large - useLarge, medium - useMedium, small, largeChar, mediumChar, smallChar);
    }
}
