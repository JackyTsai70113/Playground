namespace playground;

public class FindLatestTime3114
{
    /// <summary>
    /// https://leetcode.com/problems/latest-time-you-can-obtain-after-replacing-characters
    /// </summary>
    public static string FindLatestTime(string s)
    {
        var chs = s.ToCharArray();
        if (chs[0] == '?')
        {
            if (chs[1] == '?')
            {
                chs[0] = '1';
                chs[1] = '1';
            }
            else if (chs[1] == '0' || chs[1] == '1')
            {
                chs[0] = '1';
            }
            else
            {
                chs[0] = '0';
            }
        }
        if (chs[1] == '?')
        {
            if (chs[0] == '1')
            {
                chs[1] = '1';
            }
            else
            {
                chs[1] = '9';
            }
        }
        if (chs[3] == '?')
        {
            chs[3] = '5';
        }
        if (chs[4] == '?')
        {
            chs[4] = '9';
        }
        return new string(chs);
    }
}
