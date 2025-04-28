using playground.Notes.DataStructure;

namespace playground.UnitTest;

public class GetIntersectionNodeTest0160
{
    [Theory]
    [InlineData(8, "[4,1,8,4,5]", "[5,6,1,8,4,5]", 2, 3)]
    [InlineData(2, "[1,9,1,2,4]", "[3,2,4]", 3, 1)]
    [InlineData(0, "[2,6,4]", "[1,5]", 3, 2)]
    public void GetIntersectionNode(int intersectVal, string headAStr, string headBStr, int skipA, int skipB)
    {
        ListNode headA = headAStr.ToListNode(), headB = headBStr.ToListNode();
        ListNode cur1 = headA, cur2 = headB;
        for (int i = 0; i < skipA - 1; i++)
            cur1 = cur1.next;
        for (int i = 0; i < skipB - 1; i++)
            cur2 = cur2.next;
        cur1.next = cur2.next;
        if (intersectVal != 0)
            Assert.Equal(cur1.next.val, intersectVal);
        var actual = GetIntersectionNode0160.GetIntersectionNode(headA, headB);
        if (cur1.next == null)
            Assert.Null(actual);
        else
            Assert.Equal(cur1.next, actual);
    }
}
