namespace playground.UnitTest.LeetCode._3000_3999;

public class _3330_PossibleStringCountTest
{
    [Theory]
    [InlineData("abbcccc", 5)]
    [InlineData("abcd", 1)]
    [InlineData("aaaa", 4)]
    [InlineData("a", 1)]
    public void TestPossibleStringCount(string word, int expected)
    {
        int result = _3330_PossibleStringCount.PossibleStringCount(word);
        Assert.Equal(expected, result);
    }
}
