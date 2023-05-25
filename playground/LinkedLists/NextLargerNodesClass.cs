namespace playground.LinkedLists;

public class NextLargerNodesClass
{
    /// <remarks>https://leetcode.com/problems/next-greater-node-in-linked-list</remarks>
    public static int[] NextLargerNodes(ListNode head)
    {
        List<int> res = new(), vals = new();
        for (var cur = head; cur != null; cur = cur.next)
        {
            for (int i = 0; i < res.Count; ++i)
            {
                if (res[i] == 0 && cur.val > vals[i])
                {
                    res[i] = cur.val;
                }
            }
            res.Add(0);
            vals.Add(cur.val);
        }
        return res.ToArray();
    }
}
