using playground.DynamicPrograming;

namespace playground.UnitTest.DynamicPrograming;

public class MinExtraCharTest
{
    [Theory]
    [InlineData("leetscode", new string[] { "leet", "code", "leetcode" }, 1)]
    [InlineData("sayhelloworld", new string[] { "hello", "world" }, 3)]
    public void MinExtraChar(string str, string[] A, int expected)
    {
        int actual = MinExtraCharClass.MinExtraChar(str, A);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("leetscode", new string[] { "leet", "code", "leetcode" }, 1)]
    [InlineData("sayhelloworld", new string[] { "hello", "world" }, 3)]
    public void MinExtraChar2(string str, string[] A, int expected)
    {
        int actual = MinExtraCharClass.MinExtraChar2(str, A);
        Assert.Equal(expected, actual);
    }
}
