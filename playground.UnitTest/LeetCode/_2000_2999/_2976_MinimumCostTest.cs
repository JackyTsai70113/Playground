using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2976_MinimumCostTest
{
    [Theory]
    [InlineData("abcd", "acbe",
        new string[] { "a", "b", "c", "c", "e", "d" },
        new string[] { "b", "c", "b", "e", "b", "e" },
        new int[] { 2, 5, 5, 1, 2, 20 },
        28)]
    [InlineData("aaaa", "bbbb",
        new string[] { "a", "c" },
        new string[] { "c", "b" },
        new int[] { 1, 2 },
        12)]
    [InlineData("abcd", "abce",
        new string[] { "a" },
        new string[] { "e" },
        new int[] { 10000 },
        -1)]
    [InlineData("d", "a",
        new string[] { "b", "d", "d", "a", "c", "c", "a", "d", "a", "b" },
        new string[] { "c", "c", "b", "d", "b", "d", "b", "a", "c", "a" },
        new int[] { 9, 1, 7, 9, 2, 1, 3, 8, 8, 2 },
        5)]
    public void MinimumCost(string source, string target, string[] original, string[] changed, int[] cost, long expected)
    {
        var actual = _2976_MinimumCost.MinimumCost(source, target, original.Select(s => s[0]).ToArray(), changed.Select(s => s[0]).ToArray(), cost);
        Assert.Equal(expected, actual);
    }
}
