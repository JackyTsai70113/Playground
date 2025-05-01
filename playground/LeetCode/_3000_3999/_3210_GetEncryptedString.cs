using System.Text;

namespace playground;

public class _3210_GetEncryptedString
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-encrypted-string
    /// </summary>
    public static string GetEncryptedString(string s, int k)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            if (i + k < s.Length)
                sb.Append(s[i + k]);
            else
                sb.Append(s[(i + k) % s.Length]);
        }
        return sb.ToString();
    }
}
