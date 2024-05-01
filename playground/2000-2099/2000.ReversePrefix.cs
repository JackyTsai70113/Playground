namespace playground;

public class ReversePrefix2000
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-prefix-of-word
    /// </summary>
    public static string ReversePrefix(string word, char ch) {
        var index = word.IndexOf(ch);
        var chs = word.ToCharArray();
        Array.Reverse(chs, 0, index + 1);
        return new string(chs);
    }
}
