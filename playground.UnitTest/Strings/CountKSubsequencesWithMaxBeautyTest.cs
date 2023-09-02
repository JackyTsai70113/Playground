using playground.Strings;

namespace playground.UnitTest.Strings;

public class CountKSubsequencesWithMaxBeautyTest
{
    [Theory]
    [InlineData("bcca", 2, 4)]
    [InlineData("abbcd", 4, 2)]
    [InlineData("abc", 2, 3)]
    [InlineData("dpdemprzvz", 1, 6)]
    [InlineData("aaabbbccddeeff", 3, 72)]
    [InlineData("aa", 2, 0)]
    [InlineData("ffcsdqcnkr", 2, 4)]
    public void CountKSubsequencesWithMaxBeauty(string s, int k, int expected)
    {
        var actual = CountKSubsequencesWithMaxBeautyClass.CountKSubsequencesWithMaxBeauty(s, k);

        Assert.Equal(expected, actual);
    }
}
