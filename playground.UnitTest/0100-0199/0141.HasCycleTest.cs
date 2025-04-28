using playground.Notes.DataStructure;

namespace playground.UnitTest;

public class HasCycleTest0141
{
    [Theory]
    [InlineData("[3,2,0,-4]", 1, true)]
    [InlineData("[1,2]", 0, true)]
    [InlineData("[1,2]", -1, false)]
    [InlineData("[1]", -1, false)]
    public void HasCycle(string headStr, int pos, bool expected)
    {
        ListNode head = headStr.ToListNode(), target = head, tail = head;
        if (pos != -1)
        {
            for (int i = 0; i < pos; i++)
            {
                target = target.next;
                tail = tail.next;
            }
            while (tail.next != null)
            {
                tail = tail.next;
            }
            tail.next = target;
        }
        var actual = HasCycle0141.HasCycle(head);
        Assert.Equal(expected, actual);
    }
}
