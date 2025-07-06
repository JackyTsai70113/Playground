namespace playground.LeetCode._3000_3999;

public class _3609_MinMoves
{
    public static int MinMoves(int sx, int sy, int tx, int ty)
    {
        int moves = 0;

        while (tx > sx || ty > sy)
        {
            if (tx == ty)
            {
                if (sx == 0)
                {
                    tx = 0;
                }
                else if (sy == 0)
                {
                    ty = 0;
                }
                else
                {
                    return -1;
                }
            }
            else if (tx > ty)
            {
                if (ty >= tx - ty)
                {
                    tx -= ty;
                }
                else
                {
                    if (tx % 2 != 0) return -1;
                    tx /= 2;
                }
            }
            else
            {
                if (tx >= ty - tx)
                {
                    ty -= tx;
                }
                else
                {
                    if (ty % 2 != 0) return -1;
                    ty /= 2;
                }
            }
            moves++;
        }

        return sx == tx && sy == ty ? moves : -1;
    }
}