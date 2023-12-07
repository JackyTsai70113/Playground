using System.Text;

namespace playground;

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
        var cur = next;
        while (cur != null)
        {
            sb.Append(',');
            sb.Append(cur.val);
            cur = cur.next;
        }
        sb.Append(']');
        return sb.ToString();
    }
}