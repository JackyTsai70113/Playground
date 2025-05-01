namespace playground._3400_3499;

public class _3453_SeparateSquares
{
    public static double SeparateSquares(int[][] squares)
    {
        double total = 0;
        double l = 0, r = 1e9;
        foreach (var square in squares)
        {
            total += square[2] * square[2];
            r = Math.Max(r, square[1] + square[2]);
        }

        Array.Sort(squares, (x, y) => x[1] - y[1]);

        while (r - l > 1e-6)
        {
            double m = l + (r - l) / 2;

            // below
            double below = 0;
            foreach (var square in squares)
            {
                int y = square[1], length = square[2];
                if (y >= m) break;
                below += ((double)Math.Min(y + length, m) - y) * length;
            }
            if (Math.Abs(below * 2 - total) < 1e-6 || below * 2 > total)
                r = m;
            else
                l = m;
        }
        return l;
    }
}
