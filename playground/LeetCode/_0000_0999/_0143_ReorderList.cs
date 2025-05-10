using playground.DataStructures;

namespace playground.LeetCode._0000_0999;

public class _0143_ReorderList
{
  /// <summary>
  /// https://leetcode.com/problems/reorder-list
  /// </summary>
  public static void ReorderList(ListNode head)
  {
    ListNode slow = head, fast = head;
    while (fast.next != null && fast.next.next != null)
    {
      slow = slow.next;
      fast = fast.next.next;
    }
    var temp = slow.next;
    slow.next = null;
    slow = temp;
    ListNode reversed = null;
    while (slow != null)
    {
      var slowNext = slow.next;
      slow.next = reversed;
      reversed = slow;
      slow = slowNext;
    }
    slow = head;
    while (reversed != null)
    {
      var slowNext = slow.next;
      var reversedNext = reversed.next;
      reversed.next = slowNext;
      slow.next = reversed;
      reversed = reversedNext;
      slow = slowNext;
    }
  }
}
/*
- while (fast != null && fast.next != null)
- odd
0 1 2
  s f
  n/2
- even
0 1 2 3 -
    s   f
    n/2

- while (fast.next != null && fast.next.next != null)
- odd
0 1 2
  s f
  n/2
- even
0 1 2 3
  s f
  n/2-1
*/