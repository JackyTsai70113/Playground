namespace playground.UnitTest.LeetCode._3000_3999;

public class _3213_MinimumCostTest
{
    [Theory]
    [InlineData("wvgafw", new string[] { "wvgafw", "w" }, new int[] { 1, 2 }, 1)]
    [InlineData("abcdef", new string[] { "abdef", "abc", "d", "def", "ef" }, new int[] { 100, 1, 1, 10, 5 }, 7)]
    [InlineData("aaaa", new string[] { "z", "zz", "zzz" }, new int[] { 1, 10, 100 }, -1)]
    public void MinimumCost(string target, string[] words, int[] costs, int expected)
    {
        var actual = new _3213_MinimumCost().MinimumCost(target, words, costs);
        Assert.Equal(expected, actual);
    }
}
