namespace playground;

public class MaxHeightOfTriangle3200
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-height-of-a-triangle
    /// </summary>
    public static int MaxHeightOfTriangle(int red, int blue)
    {
        return Math.Max(Helper(red, blue), Helper(blue, red)) - 1;
    }

    public static int Helper(int color1, int color2)
    {
        int layer = 1;
        for (; layer < 100; layer++)
        {
            if (layer % 2 == 1)
            {
                if (color1 - layer < 0)
                    break;
                color1 -= layer;
            }
            else
            {
                if (color2 - layer < 0)
                    break;
                color2 -= layer;
            }
        }
        return layer;
    }
}
