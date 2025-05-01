namespace playground.LeetCode._0000_0999;

/// <summary>
/// https://leetcode.com/problems/online-stock-span
/// </summary>
public class _0901_StockSpanner
{
    readonly Stack<(int num, int count)> st = new();
    public _0901_StockSpanner() { }

    public int Next(int price)
    {
        int count = 1;
        while (st.Count > 0 && st.Peek().num <= price)
            count += st.Pop().count;
        st.Push((price, count));
        return count;
    }
}
