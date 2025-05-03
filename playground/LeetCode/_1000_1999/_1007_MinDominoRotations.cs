namespace playground.LeetCode._1000_1999;

public class _1007_MinDominoRotations
{
    /// <summary>
    /// 不要假定 tops[0], bottoms[0] 是不可以 flip 的
    /// </summary>
    /// <param name="tops"></param>
    /// <param name="bottoms"></param>
    /// <></returns>
    public static int MinDominoRotations(int[] tops, int[] bottoms)
    {
        int res = tops.Length;
        foreach (var target in new int[] { tops[0], bottoms[0] })
        {
            bool valid = true;
            int flipTop = 0, flipBottom = 0;
            for (int i = 0; i < tops.Length; i++)
            {
                if (tops[i] != target && bottoms[i] != target)
                {
                    valid = false;
                    break;
                }
                if (tops[i] != target) flipTop++;
                if (bottoms[i] != target) flipBottom++;
            }
            if (valid)
                res = Math.Min(res, Math.Min(flipTop, flipBottom));
        }
        return res == tops.Length ? -1 : res;
    }
}