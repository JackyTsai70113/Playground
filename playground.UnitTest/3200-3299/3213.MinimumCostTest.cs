namespace playground.UnitTest;

public class MinimumCostTest3213
{
    [Theory]
    [InlineData("wvgafw", new string[] { "wvgafw", "w" }, new int[] { 1, 2 }, 1)]
    [InlineData("abcdef", new string[] { "abdef", "abc", "d", "def", "ef" }, new int[] { 100, 1, 1, 10, 5 }, 7)]
    [InlineData("aaaa", new string[] { "z", "zz", "zzz" }, new int[] { 1, 10, 100 }, -1)]
    public void MinimumCost(string target, string[] words, int[] costs, int expected)
    {
        var actual = new MinimumCost3213().MinimumCost(target, words, costs);
        Assert.Equal(expected, actual);
    }
}
