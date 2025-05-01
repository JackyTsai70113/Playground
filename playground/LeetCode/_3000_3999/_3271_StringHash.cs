using System.Text;

namespace playground;

public class _3271_StringHash
{
    public static string StringHash(string s, int k)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < s.Length / k; i++)
        {
            int sum = 0;
            for (int j = i * k; j < (i + 1) * k; j++)
            {
                sum += s[j] - 'a';
            }
            sb.Append((char)(sum % 26 + 'a'));
        }
        return sb.ToString();
    }
}
