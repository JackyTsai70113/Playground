namespace playground;

public class CopyRandomList0138
{
    public static RandomNode CopyRandomList(RandomNode head)
    {
        if (head == null) return null;
        var dict = new Dictionary<RandomNode, RandomNode>();
        var cur = head;
        while (cur != null)
        {
            dict[cur] = new RandomNode(cur.val);
            cur = cur.next;
        }
        cur = head;
        var cur2 = dict[cur];
        while (cur != null)
        {
            if (cur.next != null)
                cur2.next = dict[cur.next];
            if (cur.random != null)
                cur2.random = dict[cur.random];
            cur = cur.next;
            cur2 = cur2.next;
        }
        return dict[head];
    }
}
