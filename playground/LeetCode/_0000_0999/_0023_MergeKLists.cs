using playground.DataStructures;

namespace playground.LeetCode._0000_0999;

public class _0023_MergeKLists
{
    public static ListNode MergeKLists(ListNode[] lists)
    {
        var pq = new PriorityQueue<ListNode, int>();
        foreach (var list in lists)
        {
            if (list != null)
                pq.Enqueue(list, list.val);
        }

        ListNode dummy = new ListNode(), cur = dummy;
        while (pq.Count > 0)
        {
            var node = pq.Dequeue();
            if (node.next != null)
            {
                pq.Enqueue(node.next, node.next.val);
            }
            cur.next = node;
            cur = cur.next;
        }
        return dummy.next;
    }
}
