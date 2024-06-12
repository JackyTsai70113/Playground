using System.Text;

namespace playground;

public class CountAndSay0038
{
    /// <summary>
    /// https://leetcode.com/problems/count-and-say
    /// </summary>
    public static string CountAndSay(int n)
    {
        if (n == 1)
        {
            return n.ToString();
        }

        var countAndSay = CountAndSay(n - 1);
        return RLE(countAndSay);
    }



    static string RLE(string str)
    {
        StringBuilder result = new();
        for (int i = 0; i < str.Length; ++i)
        {
            char c = str[i];
            int count = 1;
            while (i + 1 < str.Length && str[i + 1] == c)
            {
                i++;
                count++;
            }

            result.Append((char)('0' + count));
            result.Append(c);
        }

        return result.ToString();
    }
}
