using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0025_ReverseKGroupTest
{
    [Theory]
    [InlineData("[1,2]", 2, "[2,1]")]
    [InlineData("[1,2,3,4,5]", 1, "[1,2,3,4,5]")]
    [InlineData("[1,2,3,4,5]", 2, "[2,1,4,3,5]")]
    [InlineData("[1,2,3,4,5]", 3, "[3,2,1,4,5]")]
    public void ReverseKGroup(string head, int k, string expected)
    {
        var actual = _0025_ReverseKGroup.ReverseKGroup(head.ToListNode(), k);
        Assert.Equal(expected, actual.ToString());
    }
}