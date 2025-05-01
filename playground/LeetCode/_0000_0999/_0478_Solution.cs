namespace playground.LeetCode._0000_0999;

/// <summary>
/// https://leetcode.com/problems/generate-random-point-in-a-circle
/// </summary>
public class _0478_Solution
{
    private readonly double _radius;
    private readonly double _x_center;
    private readonly double _y_center;

    public _0478_Solution(double radius, double x_center, double y_center)
    {
        _radius = radius;
        _x_center = x_center;
        _y_center = y_center;
    }

    public double[] RandPoint()
    {
        var random = new Random();
        var radius = _radius * Math.Sqrt(random.NextDouble());
        var angle = Math.PI * 2 * random.NextDouble();
        return new[] {
            _x_center + radius * Math.Cos(angle),
            _y_center + radius * Math.Sin(angle) };
    }
}
