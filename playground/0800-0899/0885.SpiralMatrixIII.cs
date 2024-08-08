namespace playground;

public class SpiralMatrixIII0885
{
    int _rows;
    int _cols;
    int[][] res;
    int index = 1;
    int[] dirs = new int[] { 0, 1, 0, -1, 0 };
    public int[][] SpiralMatrixIII(int rows, int cols, int r, int c)
    {
        _rows = rows; _cols = cols;
        res = new int[rows * cols][];
        res[0] = new int[] { r, c };
        int[] cur = new int[] { r, c };
        for (int i = 1; index < rows * cols; i += 2)
        {
            Move(cur, 0, i);
            Move(cur, 1, i);
            Move(cur, 2, i + 1);
            Move(cur, 3, i + 1);
        }
        return res;
    }

    void Move(int[] cur, int dirIndex, int len)
    {
        for (int i = 1; i <= len; i++)
        {
            int newr = cur[0] + i * dirs[dirIndex];
            int newc = cur[1] + i * dirs[dirIndex + 1];
            if (IsValid(newr, newc))
            {
                res[index++] = new int[] { newr, newc };
            }
        }
        cur[0] += len * dirs[dirIndex];
        cur[1] += len * dirs[dirIndex + 1];
    }

    bool IsValid(int r, int c)
    {
        return r >= 0 && c >= 0 && r < _rows && c < _cols;
    }
}
