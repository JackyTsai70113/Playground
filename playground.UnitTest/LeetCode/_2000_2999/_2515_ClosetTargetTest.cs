using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2515_ClosetTargetTest
{
    [Theory]
    [InlineData(new string[] { "hello", "i", "am", "leetcode", "hello" }, "hello", 1, 1)]
    [InlineData(new string[] { "a", "b", "leetcode" }, "leetcode", 0, 1)]
    [InlineData(new string[] { "i", "eat", "leetcode" }, "ate", 0, -1)]
    public void ClosetTarget(string[] words, string target, int startIndex, int expected)
    {
        var actual = _2515_ClosetTarget.ClosetTarget(words, target, startIndex);
        Assert.Equal(expected, actual);
    }
}
