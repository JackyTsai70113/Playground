using playground.LeetCode._0000_0999;
using playground.LeetCode.DataStructures;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0143_ReorderListTest
{
    [Theory]
    [InlineData("[1,2,3,4]", "[1,4,2,3]")]
    [InlineData("[1,2,3,4,5]", "[1,5,2,4,3]")]
    public void ReorderList(string headStr, string expected)
    {
        ListNode head = headStr.ToListNode();
        _0143_ReorderList.ReorderList(head);
        Assert.Equal(expected, head.ToString());
    }
}
