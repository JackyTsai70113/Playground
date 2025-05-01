using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0514_FindRotateStepsTest
{
    [Theory]
    [InlineData("godding", "gd", 4)]
    [InlineData("godding", "godding", 13)]
    public void FindRotateSteps(string ring, string key, int expected)
    {
        var actual = _0514_FindRotateSteps.FindRotateSteps(ring, key);
        Assert.Equal(expected, actual);
    }
}
