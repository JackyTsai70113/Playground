namespace playground;

public class ModifiedList3217
{
    public static ListNode ModifiedList(int[] nums, ListNode head)
    {
        var set = nums.ToHashSet<int>();
        ListNode dummy = new ListNode(0, head), cur = dummy;
        while (cur.next != null)
        {
            if (set.Contains(cur.next.val))
            {
                cur.next = cur.next.next;
            }
            else
            {
                cur = cur.next;
            }
        }
        return dummy.next;
    }
}
