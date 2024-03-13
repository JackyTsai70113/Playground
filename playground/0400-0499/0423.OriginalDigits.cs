using System.Text;

namespace playground;

public class OriginalDigits0423
{
    /// <summary>
    /// https://leetcode.com/problems/reconstruct-original-digits-from-english
    /// </summary>
    public static string OriginalDigits(string s)
    {
        var count = new int[10];
        foreach (var c in s)
        {
            if (c == 'z') count[0]++;
            else if (c == 'o') count[1]++;
            else if (c == 'w') count[2]++;
            else if (c == 'h') count[3]++;
            else if (c == 'u') count[4]++;
            else if (c == 'f') count[5]++;
            else if (c == 'x') count[6]++;
            else if (c == 's') count[7]++;
            else if (c == 'g') count[8]++;
            else if (c == 'i') count[9]++;
        }
        count[1] -= count[0] + count[2] + count[4];
        count[3] -= count[8];
        count[5] -= count[4];
        count[7] -= count[6];
        count[9] -= count[6] + count[5] + count[8];
        var res = new StringBuilder();
        for (int i = 0; i <= 9; i++)
        {
            res.Append((char)(i + '0'), count[i]);
        }
        return res.ToString();
    }
}
