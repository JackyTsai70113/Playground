namespace playground;

public class LargestRectangleArea0084
{
    /// <summary>
    /// https://leetcode.com/problems/largest-rectangle-in-histogram
    /// </summary>
    public static int LargestRectangleArea(int[] A)
    {
        int[] ple = new int[A.Length], nle = new int[A.Length];
        Stack<int> st = new();
        for (int i = 0; i < A.Length; ++i)
        {
            while (st.Count > 0 && A[st.Peek()] >= A[i])
                st.Pop();
            ple[i] = st.Count == 0 ? -1 : st.Peek();
            st.Push(i);
        }

        st.Clear();
        for (int i = A.Length - 1; i >= 0; --i)
        {
            while (st.Count > 0 && A[st.Peek()] >= A[i])
                st.Pop();
            nle[i] = st.Count == 0 ? A.Length : st.Peek();
            st.Push(i);
        }

        var res = 0;
        for (int i = 0; i < A.Length; i++)
        {
            res = Math.Max(res, A[i] * (nle[i] - ple[i] - 1));
        }
        return res;
    }

    public static int LargestRectangleArea2(int[] A)
    {
        int res = 0;
        Stack<int> st = new();
        for (int i = 0; i <= A.Length; ++i)
        {
            var cur = i == A.Length ? 0 : A[i];
            while (st.Count > 0 && A[st.Peek()] > cur)
            {
                int h = A[st.Pop()];
                int w = st.Count == 0 ? i : i - st.Peek() - 1;
                res = Math.Max(res, h * w);
            }
            st.Push(i);
        }
        return res;
    }


}
