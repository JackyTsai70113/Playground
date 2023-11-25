namespace playground.UnitTest;

public class LongestCommonPrefixTest_0014
{
    [Theory]
    [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new string[] { "fl", "flow", "flight" }, "fl")]
    [InlineData(new string[] { "dog", "racecar", "car" }, "")]
    [InlineData(new string[] { "dog", "do"}, "do")]
    public void LongestCommonPrefix(string[] strs, string expected)
    {
        var actual = LongestCommonPrefix_0014.LongestCommonPrefix(strs);
        Assert.Equal(expected, actual);
    }
}
