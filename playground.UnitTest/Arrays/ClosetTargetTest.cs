using playground.Arrays;

namespace playground.UnitTest.Arrays;

public class ClosetTargetTest
{
    [Theory]
    [InlineData(new string[] { "hello", "i", "am", "leetcode", "hello" }, "hello", 1, 1)]
    [InlineData(new string[] { "a", "b", "leetcode" }, "leetcode", 0, 1)]
    [InlineData(new string[] { "i", "eat", "leetcode" }, "ate", 0, -1)]
    public void ClosetTarget(string[] words, string target, int startIndex, int expected)
    {
        var actual = ClosetTargetClass.ClosetTarget(words, target, startIndex);
        Assert.Equal(expected, actual);
    }
}
