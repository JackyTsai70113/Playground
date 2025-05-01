using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0206_ReverseListTest
{
    [Theory]
    [InlineData("[]", "[]")]
    [InlineData("[1,2]", "[2,1]")]
    [InlineData("[5,3,2,1]", "[1,2,3,5]")]
    [InlineData("[1,2,3,4,5]", "[5,4,3,2,1]")]
    public void ReverseList(string head, string expected)
    {
        var actual = _0206_ReverseList.ReverseList(head.ToListNode());
        if (!expected.ToArr().Any())
            Assert.Null(actual);
        else
            Assert.Equal(expected, actual.ToString());
    }
}
