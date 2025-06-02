namespace playground.LeetCode._3000_3999;

public class _3001_MinMovesToCaptureTheQueen
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-moves-to-capture-the-queen
    /// </summary>
    public static int MinMovesToCaptureTheQueen(int a, int b, int c, int d, int e, int f)
    {
        if (a == e && (a != c || (d - b) * (d - f) > 0))
        {
            return 1;
        }
        else if (b == f && (b != d || (c - a) * (c - e) > 0))
        {
            return 1;
        }
        else if (c - d == e - f && (a - b != e - f || (a - c) * (a - e) > 0))
        {
            return 1;
        }
        else if (c + d == e + f && (a + b != e + f || (a - c) * (a - e) > 0))
        {
            return 1;
        }
        return 2;
    }
}
