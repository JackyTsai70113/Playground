namespace playground;

public class CountSubstrings3084
{
    /// <summary>
    /// https://leetcode.com/problems/count-substrings-starting-and-ending-with-given-character
    /// </summary>
    public static long CountSubstrings(string s, char c)
    {
        long res = 0, count = 1;
        foreach (var cc in s)
        {
            if (cc == c)
            {
                res += count++;
            }
        }
        return res;
    }
}
