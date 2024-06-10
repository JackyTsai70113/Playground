namespace playground.UnitTest;

public class DeleteNodeTest0237
{
    [Theory]
    [InlineData("[4,5,1,9]", 5, "[4,1,9]")]
    [InlineData("[4,5,1,9]", 1, "[4,5,9]")]
    public void DeleteNode(string A, int val, string expected)
    {
        var head = A.ToListNode();
        var cur = head;
        while (cur != null)
        {
            if (cur.val == val)
                break;
            cur = cur.next;
        }
        DeleteNode0237.DeleteNode(cur);
        Assert.Equal(expected, head.ToString());
    }
}
