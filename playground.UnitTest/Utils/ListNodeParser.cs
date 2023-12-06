namespace playground.UnitTest.Utils;

public static class ListNodeParser
{
    public static ListNode ToListNode(this string str)
    {
        ListNode res = new(), p = res;
        var nums = str.ToArr();
        foreach (var num in nums)
        {
            p.next = new ListNode(num);
            p = p.next;
        }
        return res.next;
    }
}
