namespace playground;

public class ClosetTarget_2515
{
    /// <summary>
    /// https://leetcode.com/problems/shortest-distance-to-target-string-in-a-circular-array
    /// </summary>
    public static int ClosetTarget(string[] words, string target, int startIndex)
    {
        int n = words.Length, res = int.MaxValue, len;
        for (int i = 0; i < n; i++)
        {
            if (words[i] == target)
            {
                len = Math.Abs(startIndex - i);
                res = Math.Min(res, len);
                res = Math.Min(res, n - len);
            }
        }
        return res == int.MaxValue ? -1 : res;
    }
}
