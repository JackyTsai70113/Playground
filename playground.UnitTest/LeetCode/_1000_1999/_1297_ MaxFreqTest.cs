using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1297__MaxFreqTest
{
    [Theory]
    [InlineData("aababcaab", 2, 3, 4, 2)]
    [InlineData("aaaa", 1, 3, 3, 2)]
    [InlineData("abcde", 2, 3, 3, 0)]
    public void Test(string s, int maxLetters, int minSize, int maxSize, int expected)
    {
        Assert.Equal(expected, _1297__MaxFreq.MaxFreq(s, maxLetters, minSize, maxSize));
    }
}
