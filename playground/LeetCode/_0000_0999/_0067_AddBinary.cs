using System.Text;

namespace playground.LeetCode._0000_0999;

public class _0067_AddBinary
{
    /// <summary>
    /// https://leetcode.com/problems/add-binary
    /// </summary>
    public static string AddBinary(string a, string b)
    {
        var sb = new StringBuilder();
        int i = a.Length - 1, j = b.Length - 1, carry = 0;
        while (i >= 0 || j >= 0)
        {
            int x = i >= 0 ? a[i--] - '0' : 0;
            int y = j >= 0 ? b[j--] - '0' : 0;
            int sum = x + y + carry;
            sb.Insert(0, sum % 2);
            carry = sum / 2;
        }
        if (carry > 0) sb.Insert(0, 1);
        return sb.ToString();
    }
}
