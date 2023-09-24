namespace playground.DynamicPrograming;

public class ChampagneTowerClass
{
    public static double ChampagneTower(int poured, int query_row, int query_glass)
    {
        var tower = new double[query_row + 1, query_row + 1];
        tower[0, 0] = poured;
        for (int i = 0; i < query_row; ++i)
        {
            for (int j = 0; j < query_row; ++j)
            {
                double remaining = (tower[i, j] - 1) / 2;
                if (remaining > 0)
                {
                    tower[i + 1, j] += remaining;
                    tower[i + 1, j + 1] += remaining;
                }
            }
        }
        return Math.Min(1, tower[query_row, query_glass]);
    }
}
