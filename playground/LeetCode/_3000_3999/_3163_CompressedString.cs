using System.Text;

namespace playground;

public class _3163_CompressedString
{
    /// <summary>
    /// https://leetcode.com/problems/string-compression-iii
    /// </summary>
    public static string CompressedString(string word)
    {
        StringBuilder res = new(); ;
        for (int i = 0; i < word.Length; i++)
        {
            int len = 1;
            while (len <= 9 && i + len - 1 < word.Length && word[i] == word[i + len - 1]) len++;
            res.Append((len - 1).ToString() + word[i]);
            i = i + len - 2;
        }
        return res.ToString();
    }
}
