namespace playground.LeetCode._0000_0999;

public class _0017_LetterCombinations
{
    /// <summary>
    /// https://leetcode.com/problems/letter-combinations-of-a-phone-number
    /// </summary>
    public static IList<string> LetterCombinations(string digits)
    {
        var res = new List<string>();
        if (digits.Length == 0) return res;
        Bt(digits, 0, new List<char>(), res);
        return res;
    }

    static void Bt(string digits, int start, List<char> cur, IList<string> res)
    {
        if (start == digits.Length)
        {
            res.Add(new string(cur.ToArray()));
            return;
        }
        List<char> temp = new();
        switch (digits[start])
        {
            case '2':
                temp = new List<char> { 'a', 'b', 'c' };
                break;
            case '3':
                temp = new List<char> { 'd', 'e', 'f' };
                break;
            case '4':
                temp = new List<char> { 'g', 'h', 'i' };
                break;
            case '5':
                temp = new List<char> { 'j', 'k', 'l' };
                break;
            case '6':
                temp = new List<char> { 'm', 'n', 'o' };
                break;
            case '7':
                temp = new List<char> { 'p', 'q', 'r', 's' };
                break;
            case '8':
                temp = new List<char> { 't', 'u', 'v' };
                break;
            case '9':
                temp = new List<char> { 'w', 'x', 'y', 'z' };
                break;
        }
        foreach (var c in temp)
        {
            cur.Add(c);
            Bt(digits, start + 1, cur, res);
            cur.RemoveAt(cur.Count - 1);
        }
    }
}
