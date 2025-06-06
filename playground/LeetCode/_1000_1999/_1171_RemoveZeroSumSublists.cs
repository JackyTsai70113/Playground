using playground.DataStructures;

namespace playground.LeetCode._1000_1999;

public class _1171_RemoveZeroSumSublists
{
    public static ListNode RemoveZeroSumSublists(ListNode head)
    {
        var st = new Stack<int>();
        var set = new HashSet<int>() { 0 };
        ListNode cur = head, res = null;
        var sum = 0;
        st.Push(0);
        while (cur != null)
        {
            sum += cur.val;
            if (set.Contains(sum))
            {
                while (st.Peek() != sum)
                {
                    set.Remove(st.Pop());
                }
            }
            else
            {
                st.Push(sum);
                set.Add(sum);
            }
            cur = cur.next;
        }
        while (st.Count > 1)
        {
            res = new ListNode(st.Pop() - st.Peek(), res);
        }
        return res;
    }
}
