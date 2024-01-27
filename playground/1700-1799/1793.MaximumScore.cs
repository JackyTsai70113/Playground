namespace playground;

public class MaximumScore1793
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-score-of-a-good-subarray
    /// </summary>
    public static int MaximumScore(int[] A, int k)
    {
        int n = A.Length, res = A[k], min = A[k], l = k, r = k;
        while (l > 0 || r < n - 1)
        {
            if (l == 0)
                r++;
            else if (r == n - 1)
                l--;
            else if (A[l - 1] < A[r + 1])
                r++;
            else
                l--;
            min = Math.Min(min, Math.Min(A[l], A[r]));
            res = Math.Max(res, min * (r - l + 1));
        }
        return res;
    }

    public static int MaximumScore2(int[] A, int k)
    {
        int n = A.Length, res = A[k];
        int[] pge = new int[n], nge = new int[n];
        Stack<int> st = new();
        for (int i = 0; i < n; ++i)
        {
            while (st.Count > 0 && A[st.Peek()] >= A[i])
                st.Pop();
            pge[i] = st.Count == 0 ? -1 : st.Peek();
            st.Push(i);
        }

        st.Clear();
        for (int i = n - 1; i >= 0; --i)
        {
            while (st.Count > 0 && A[st.Peek()] >= A[i])
                st.Pop();
            nge[i] = st.Count == 0 ? n : st.Peek();
            st.Push(i);
        }

        for (int i = 0; i < n; i++)
        {
            if (pge[i] <= k && k <= nge[i])
                res = Math.Max(res, A[i] * (nge[i] - pge[i] - 1));
        }
        return res;
    }
}
