namespace playground;

public class DailyTemperatures0739
{
    /// <summary>
    /// https://leetcode.com/problems/daily-temperatures/
    /// </summary>
    public static int[] DailyTemperatures(int[] A)
    {
        int n = A.Length;
        int[] res = new int[n];
        Stack<int> st = new();
        for (int i = n - 1; i >= 0; --i)
        {
            while (st.Count > 0 && A[st.Peek()] < A[i])
                st.Pop();
            res[i] = st.Count == 0 ? 0 : st.Peek() - i;
            st.Push(i);
        }
        return res;
    }
}
