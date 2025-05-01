using playground.LeetCode.DataStructures;

namespace playground;

public class _1367_IsSubPath
{
    public static bool IsSubPath(ListNode head, TreeNode root)
    {
        return Dfs(head, head, root);
    }
    static bool Dfs(ListNode head, ListNode cur, TreeNode root)
    {
        if (cur == null) return true;
        if (root == null) return false;
        if (cur.val == root.val)
            cur = cur.next;
        else if (head.val == root.val)
            head = head.next;
        else
            cur = head;
        return Dfs(head, cur, root.left) || Dfs(head, cur, root.right);
    }
}
