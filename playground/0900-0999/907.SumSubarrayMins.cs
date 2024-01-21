namespace playground;

public class SumSubarrayMins907
{
    /// <summary>
    /// https://leetcode.com/problems/sum-of-subarray-minimums
    /// </summary>
    public static int SumSubarrayMins(int[] A)
    {
        int n = A.Length, MOD = (int)1e9 + 7;
        long res = 0;
        int[] previousLessIndex = new int[n], nextLessIndex = new int[n];
        Stack<int> st = new();
        for (int i = 0; i < n; ++i)
        {
            // 相等的拿掉，所以會計算到
            // 也就是若是有相同的元素造成一樣的最小值，以後者為主。
            while (st.Count > 0 && A[st.Peek()] >= A[i])
                st.Pop();
            previousLessIndex[i] = st.Count == 0 ? -1 : st.Peek();
            st.Push(i);
        }

        st = new();
        for (int i = n - 1; i >= 0; --i)
        {
            // 相等的不拿掉，所以不會計算到
            // 也就是若是有相同的元素造成一樣的最小值，以後者為主。
            while (st.Count > 0 && A[st.Peek()] > A[i])
                st.Pop();
            nextLessIndex[i] = st.Count == 0 ? n : st.Peek();
            st.Push(i);
        }

        // arr: 0 5 5 5 7
        // pli: 0 1 1 1 3
        // nli: 1 2 3 4 5

        for (int i = 0; i < n; ++i)
        {
            res = (res + (long)A[i] * (i - previousLessIndex[i]) * (nextLessIndex[i] - i)) % MOD;
        }
        return (int)res;
    }
}
