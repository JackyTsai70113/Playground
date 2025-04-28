using playground.Notes.DataStructure;

namespace playground.UnitTest;

public class ReorderListTest_0143
{
    [Theory]
    [InlineData("[1,2,3,4]", "[1,4,2,3]")]
    [InlineData("[1,2,3,4,5]", "[1,5,2,4,3]")]
    public void ReorderList(string headStr, string expected)
    {
        ListNode head = headStr.ToListNode();
        ReorderList_0143.ReorderList(head);
        Assert.Equal(expected, head.ToString());
    }
}
