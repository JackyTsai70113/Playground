using playground.Notes.DataStructure;

namespace playground;

public class ReverseList0206
{
    public static ListNode ReverseList(ListNode head)
    {
        if (head == null)
            return null;
        return ListNode.Reverse(head);
    }
}
