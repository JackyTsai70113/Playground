namespace playground;

public class _3136_IsValid
{
    /// <summary>
    /// https://leetcode.com/problems/valid-word
    /// </summary>
    public static bool IsValid(string word)
    {
        if (word.Length < 3) return false;
        var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
        bool a = false, b = false;
        foreach (var c in word)
        {
            if ('0' <= c && c <= '9')
            {

            }
            else if ('a' <= c && c <= 'z')
            {
                if (vowels.Contains(c))
                    a = true;
                else
                    b = true;
            }
            else if ('A' <= c && c <= 'Z')
            {
                var c1 = char.ToLower(c);
                if (vowels.Contains(c1))
                    a = true;
                else
                    b = true;
            }
            else
            {
                return false;
            }
        }
        return a && b;
    }
}
