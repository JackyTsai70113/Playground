using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0019_RemoveNthFromEndTest
{
    [Theory]
    [InlineData("[1,2,3,4,5]", 2, "[1,2,3,5]")]
    [InlineData("[1]", 1, "[]")]
    [InlineData("[1,2]", 1, "[1]")]
    public void RemoveNthFromEnd(string head, int n, string expected)
    {
        var actual = _0019_RemoveNthFromEnd.RemoveNthFromEnd(head.ToListNode(), n);
        if (!expected.ToArr().Any())
            Assert.Null(actual);
        else
            Assert.Equal(expected, actual.ToString());
    }
}
