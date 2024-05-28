namespace playground;

public class FindRadius0475
{
    /// <summary>
    /// https://leetcode.com/problems/heaters
    /// </summary>
    public static int FindRadius(int[] houses, int[] heaters)
    {
        Array.Sort(houses);
        Array.Sort(heaters);
        int i = 0;
        int radius = 0;
        foreach (var h in houses)
        {
            while (i + 1 < heaters.Length && heaters[i] + heaters[i + 1] <= 2 * h)
                i++;
            radius = Math.Max(radius, Math.Abs(heaters[i] - h));
        }
        return radius;
    }
}
