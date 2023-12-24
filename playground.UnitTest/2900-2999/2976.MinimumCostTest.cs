namespace playground.UnitTest;

public class MinimumCostTest2976
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
    public void MinimumCost(string source, string target, string[] original, string[] changed, int[] cost, long expected)
    {
        var actual = MinimumCost2976.MinimumCost(source, target, original.Select(s => s[0]).ToArray(), changed.Select(s => s[0]).ToArray(), cost);
        Assert.Equal(expected, actual);
    }
}
