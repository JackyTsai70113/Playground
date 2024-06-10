namespace playground;

public class DeleteNode0237
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
