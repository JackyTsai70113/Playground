using playground.DataStructures;

namespace playground.LeetCode._0000_0999;

public class _0237_DeleteNode
{
    /// <summary>
    /// https://leetcode.com/problems/delete-node-in-a-linked-list
    /// </summary>
    public static void DeleteNode(ListNode node)
    {
        node.val = node.next.val;
        node.next = node.next.next;
    }
}
