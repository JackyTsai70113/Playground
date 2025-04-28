using playground.Notes.DataStructure;

namespace playground;

public class ReverseKGroup_0025
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-nodes-in-k-group
    /// </summary>
    public static ListNode ReverseKGroup(ListNode head, int k)
    {
        if (k == 1) return head;
        ListNode pre = new() { next = head }, begin = pre;
        ListNode cur = head;
        int i = 0;
        while (cur != null)
        {
            i++;
            if (i % k == 0)
            {
                begin = Reverse(begin, cur.next);
                cur = begin.next;
            }
            else
            {
                cur = cur.next;
            }
        }
        return pre.next;
    }

    /// <summary>
    /// Reverse a link list between begin and end exclusively
    /// 0->1->2->3->4->5->6
    /// |           |   
    /// begin       end
    /// after call begin = Reverse(begin, end)
    /// 
    /// 0->3->2->1->4->5->6
    ///          |  |
    ///      begin end
    /// </summary>
    /// <returns>the reversed list's 'begin' node, which is the precedence of node end</returns>
    private static ListNode Reverse(ListNode begin, ListNode end)
    {
        ListNode cur = begin, tail = begin.next;
        while (tail.next != end)
        {
            var temp = cur.next;
            cur.next = tail.next;
            tail.next = tail.next.next;
            cur.next.next = temp;
        }
        return tail;
    }
}
