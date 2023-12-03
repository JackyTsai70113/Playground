namespace playground.UnitTest;

public class CountCompleteSubstringsTest_2953
{
    [Theory]
    [InlineData("igigee", 2, 3)]
    [InlineData("aaabbbccc", 3, 6)]
    [InlineData("aca", 1, 5)]
    [InlineData("jjjqq", 1, 5)]
    public void CountCompleteSubstrings(string s, int k, int expected)
    {
        var actual = CountCompleteSubstrings_2953.CountCompleteSubstrings(s, k);
        Assert.Equal(expected, actual);
    }
}
