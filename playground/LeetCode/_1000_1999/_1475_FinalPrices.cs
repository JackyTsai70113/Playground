namespace playground.LeetCode._1000_1999;

public class _1475_FinalPrices
{
    public static int[] FinalPrices(int[] prices)
    {
        int n = prices.Length;
        var res = new int[n];
        var st = new Stack<int>();
        for (int j = n - 1; j >= 0; j--)
        {
            while (st.Count > 0 && prices[st.Peek()] > prices[j])
                st.Pop();
            res[j] = prices[j] - (st.Count == 0 ? 0 : prices[st.Peek()]);
            st.Push(j);
        }
        return res;
    }
}
