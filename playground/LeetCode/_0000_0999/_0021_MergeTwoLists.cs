using playground.DataStructures;

namespace playground.LeetCode._0000_0999;

public class _0021_MergeTwoLists
{
    /// <summary>
    /// https://leetcode.com/problems/merge-two-sorted-lists
    /// </summary>
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null) return list2;
        if (list2 == null) return list1;
        if (list1.val < list2.val)
        {
            list1.next = MergeTwoLists(list1.next, list2);
            return list1;
        }
        else
        {
            list2.next = MergeTwoLists(list1, list2.next);
            return list2;
        }
    }
}
