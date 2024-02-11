namespace playground;

public class MinSpeedOnTime1870
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-speed-to-arrive-on-time
    /// </summary>
    public static int MinSpeedOnTime(int[] dist, double hour)
    {
        if (dist.Length > Math.Ceiling(hour)) return -1;
        int l = 1, r = int.MaxValue;
        while (l < r)
        {
            int speed = l + (r - l) / 2;
            double time = 0;
            for (int i = 0; i < dist.Length; i++)
                time += i == dist.Length - 1 ? (double)dist[i] / speed : (dist[i] + speed - 1) / speed;
            if (time <= hour)
                r = speed;
            else
                l = speed + 1;
        }
        return l;
    }
}
