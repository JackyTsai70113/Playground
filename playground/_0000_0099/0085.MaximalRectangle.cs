namespace playground;

public class MaximalRectangle0085
{
    /// <summary>
    /// https://leetcode.com/problems/maximal-rectangle
    /// </summary>
    public static int MaximalRectangle(char[][] A)
    {
        int m = A.Length, n = A[0].Length, res = 0;
        int[] h = new int[n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                h[j] = A[i][j] == '1' ? h[j] + 1 : 0;
            }

            int[] ple = new int[n], nle = new int[n];
            Stack<int> st1 = new(), st2 = new();
            for (int j = 0; j < n; j++)
            {
                while (st1.Count > 0 && h[st1.Peek()] >= h[j])
                    st1.Pop();
                ple[j] = st1.Count == 0 ? -1 : st1.Peek();
                st1.Push(j);
            }
            for (int j = n - 1; j >= 0; j--)
            {
                while (st2.Count > 0 && h[st2.Peek()] >= h[j])
                    st2.Pop();
                nle[j] = st2.Count == 0 ? n : st2.Peek();
                st2.Push(j);
            }
            for (int j = 0; j < n; j++)
            {
                res = Math.Max(res, h[j] * (nle[j] - ple[j] - 1));
            }
        }
        return res;
    }
}
