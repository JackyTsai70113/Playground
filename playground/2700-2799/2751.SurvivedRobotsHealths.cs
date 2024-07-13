namespace playground;

public class SurvivedRobotsHealths2751
{
    /// <summary>
    /// https://leetcode.com/problems/robot-collisions
    /// </summary>
    public static IList<int> SurvivedRobotsHealths(int[] positions, int[] healths, string directions)
    {
        int n = positions.Length;
        int[] indexes = new int[n];
        for (int i = 0; i < n; i++) indexes[i] = i;
        Array.Sort(positions, indexes);
        Stack<int> robots = new();
        foreach (var cur in indexes)
        {
            robots.Push(cur);
            while (robots.Count > 1)
            {
                var right = robots.Pop();
                var left = robots.Pop();
                if (!(directions[left] == 'R' && directions[right] == 'L'))
                {
                    robots.Push(left);
                    robots.Push(right);
                    break;
                }
                if (healths[left] > healths[right] && --healths[left] > 0)
                {
                    robots.Push(left);
                }
                else if (healths[left] < healths[right] && --healths[right] > 0)
                {
                    robots.Push(right);
                }
            }
        }
        return robots.OrderBy(idx => idx).Select(idx => healths[idx]).ToList();
    }
}
