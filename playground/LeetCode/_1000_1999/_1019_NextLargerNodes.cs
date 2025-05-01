using playground.LeetCode.DataStructures;

namespace playground.LeetCode._1000_1999;

public class _1019_NextLargerNodes
{
    public static int[] NextLargerNodes(ListNode head)
    {
        var arr = new List<int>();
        for (var cur = head; cur != null; cur = cur.next)
        {
            arr.Add(cur.val);
        }
        var res = new int[arr.Count];
        var stack = new Stack<int>();
        for (int i = arr.Count - 1; i >= 0; i--)
        {
            while (stack.Count > 0 && arr[stack.Peek()] <= arr[i])
            {
                stack.Pop();
            }
            res[i] = stack.Count == 0 ? 0 : arr[stack.Peek()];
            stack.Push(i);
        }
        return res;
    }
}
