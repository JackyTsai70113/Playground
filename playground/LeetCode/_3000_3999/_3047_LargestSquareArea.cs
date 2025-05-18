namespace playground.LeetCode._3000_3999;

public class _3047_LargestSquareArea
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-largest-area-of-square-inside-two-rectangles
    /// </summary>
    public static long LargestSquareArea(int[][] bottomLeft, int[][] topRight)
    {
        int n = bottomLeft.Length;
        long maxSize = 0;
        for (int i = 0; i < n; i++)
        {
            int blx1 = bottomLeft[i][0], bly1 = bottomLeft[i][1];
            int trx1 = topRight[i][0], try1 = topRight[i][1];
            for (int j = i + 1; j < n; j++)
            {
                int blx2 = bottomLeft[j][0], bly2 = bottomLeft[j][1];
                int trx2 = topRight[j][0], try2 = topRight[j][1];
                if (trx2 > blx1 && try2 > bly1 && trx1 > blx2 && try1 > bly2)
                {
                    int w = Math.Min(trx1, trx2) - Math.Max(blx1, blx2);
                    int h = Math.Min(try1, try2) - Math.Max(bly1, bly2);
                    maxSize = Math.Max(maxSize, Math.Min(w, h));
                }
            }
        }
        return maxSize * maxSize;
    }
}
