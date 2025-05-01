namespace playground.LeetCode._0000_0999;

public class _0402_RemoveKdigits
{
    /// <summary>
    /// https://leetcode.com/problems/remove-k-digits
    /// </summary>
    public static string RemoveKdigits(string num, int k)
    {
        Stack<char> st = new();
        for (int i = 0; i < num.Length; i++)
        {
            while (st.Count > 0 && k > 0 && st.Peek() > num[i])
            {
                st.Pop();
                k--;
            }
            if (st.Count > 0 || num[i] != '0')
                st.Push(num[i]);
        }
        while (st.Count > 0 && k-- > 0)
        {
            st.Pop();
        }
        var chs = st.Reverse().ToArray();
        return chs.Length > 0 ? new string(chs) : "0";
    }
}
