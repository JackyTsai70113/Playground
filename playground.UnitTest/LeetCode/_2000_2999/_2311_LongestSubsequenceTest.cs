using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2311_LongestSubsequenceTest
{
    [Theory]
    [InlineData("1001010", 5, 5)]
    [InlineData("00101001", 1, 6)]
    public void TestLongestSubsequence(string s, int k, int expected)
    {
        int result = _2311_LongestSubsequence.LongestSubsequence(s, k);
        Assert.Equal(expected, result);
    }
}