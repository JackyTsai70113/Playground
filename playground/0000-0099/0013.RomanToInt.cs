namespace playground;

public class RomanToInt_0013
{
    /// <summary>
    /// https://leetcode.com/problems/roman-to-integer
    /// </summary>
    public static int RomanToInt(string s)
    {
        var d = new Dictionary<char, int>{
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000},
        };
        int res = 0;
        for (int i = 0; i < s.Length; ++i)
        {
            if (i < s.Length - 1 && d[s[i]] < d[s[i + 1]])
            {
                res += d[s[i + 1]] - d[s[i]];
                i++;
            }
            else
            {
                res += d[s[i]];
            }
        }
        return res;
    }
}
