using playground.LeetCode.DataStructures;

namespace playground.LeetCode._0000_0999;

public class _0725_SplitListToParts
{
    public static ListNode[] SplitListToParts(ListNode head, int k)
    {
        var res = new ListNode[k];
        var nodeCount = 0;
        ListNode cur = head, cur2;
        while (cur != null)
        {
            nodeCount++;
            cur = cur.next;
        }
        cur = head;
        for (int i = 0; i < k; i++)
        {
            int count = nodeCount / k + (nodeCount % k > i ? 1 : 0);
            var pre = new ListNode();
            cur2 = pre;
            for (int j = 0; j < count; ++j)
            {
                cur2.next = cur;
                cur2 = cur2.next;
                cur = cur.next;
            }
            cur2.next = null;
            res[i] = pre.next;
        }
        return res;
    }
}
