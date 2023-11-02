namespace playground.Backtracking;

public class LetterCombinationsClass
{
    /// <summary>
    /// https://leetcode.com/problems/letter-combinations-of-a-phone-number
    /// </summary>
    public static IList<string> LetterCombinations(string digits)
    {
        var res = new List<string>();
        if (digits.Length == 0) return res;
        void dfs(int cur, char[] chs)
        {
            if (cur == digits.Length)
            {
                res.Add(string.Join("", chs));
                return;
            }
            char[] cs = Array.Empty<char>();
            switch (digits[cur])
            {
                case '2':
                    cs = new char[] { 'a', 'b', 'c' };
                    break;
                case '3':
                    cs = new char[] { 'd', 'e', 'f' };
                    break;
                case '4':
                    cs = new char[] { 'g', 'h', 'i' };
                    break;
                case '5':
                    cs = new char[] { 'j', 'k', 'l' };
                    break;
                case '6':
                    cs = new char[] { 'm', 'n', 'o' };
                    break;
                case '7':
                    cs = new char[] { 'p', 'q', 'r', 's' };
                    break;
                case '8':
                    cs = new char[] { 't', 'u', 'v' };
                    break;
                case '9':
                    cs = new char[] { 'w', 'x', 'y', 'z' };
                    break;
            }
            foreach (var c in cs)
            {
                chs[cur] = c;
                dfs(cur + 1, chs);
            }
        }
        dfs(0, new char[digits.Length]);
        return res;
    }
}
