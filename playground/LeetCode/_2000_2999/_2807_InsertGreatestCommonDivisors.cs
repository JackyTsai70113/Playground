using playground.LeetCode.DataStructures;

namespace playground.LeetCode._2000_2999;

public class _2807_InsertGreatestCommonDivisors
{
    public static ListNode InsertGreatestCommonDivisors(ListNode head)
    {
        static int Gcd(int x, int y)
        {
            return y == 0 ? x : Gcd(y, x % y);
        }

        var cur = head;
        while (cur.next != null)
        {
            int gcd = Gcd(cur.val, cur.next.val);
            cur.next = new ListNode(gcd, cur.next);
            cur = cur.next.next;
        }
        return head;
    }
}
