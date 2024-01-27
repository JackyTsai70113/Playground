namespace playground;

/// <summary>
/// https://leetcode.com/problems/online-stock-span
/// </summary>
public class StockSpanner0901
{
    readonly Stack<(int num, int count)> st = new();
    public StockSpanner0901() { }

    public int Next(int price)
    {
        int count = 1;
        while (st.Count > 0 && st.Peek().num <= price)
            count += st.Pop().count;
        st.Push((price, count));
        return count;
    }
}
