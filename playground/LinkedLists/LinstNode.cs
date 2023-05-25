using System.Text;

namespace playground.LinkedLists;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append('[');
        sb.Append(val);
        sb.Append(',');
        var cur = next;
        while (cur != null)
        {
            sb.Append(cur.val);
            sb.Append(',');
            cur = cur.next;
        }
        sb.Remove(sb.Length - 1, 1);
        sb.Append(']');
        return sb.ToString();
    }
}

public static class ListNodeExtension
{
    public static ListNode Reverse(ListNode head)
    {
        ListNode pre = new(), p = head;
        while (p != null)
        {
            var temp = p.next;
            p.next = pre.next;
            pre.next = p;
            p = temp;
        }
        return pre.next;
    }
}
