namespace playground.LeetCode._0000_0999;

public class _0874_RobotSim
{
    readonly Dictionary<int, SortedSet<int>> verticalObstacles = new();   // x -> set of y
    readonly Dictionary<int, SortedSet<int>> horizontalObstacles = new(); // y -> set of x
    readonly int[] dx = new int[] { 0, 1, 0, -1 };
    readonly int[] dy = new int[] { 1, 0, -1, 0 };

    public int RobotSim(int[] commands, int[][] obstacles)
    {
        foreach (var ob in obstacles)
        {
            AddObstacle(verticalObstacles, ob[0], ob[1]);    // x -> y
            AddObstacle(horizontalObstacles, ob[1], ob[0]);  // y -> x
        }

        int x = 0, y = 0, dir = 0, max = 0;

        foreach (var cmd in commands)
        {
            if (cmd == -1) dir = (dir + 1) % 4;
            else if (cmd == -2) dir = (dir + 3) % 4;
            else Move(ref x, ref y, dir, cmd);
            max = Math.Max(max, x * x + y * y);
        }

        return max;
    }

    void Move(ref int x, ref int y, int dir, int steps)
    {
        if (dx[dir] == 0)
            y = MoveVertical(x, y, dy[dir], steps);
        else
            x = MoveHorizontal(y, x, dx[dir], steps);
    }

    int MoveVertical(int x, int y, int dy, int steps)
    {
        int targetY = y + dy * steps;

        if (!verticalObstacles.TryGetValue(x, out var ySet))
            return targetY;

        if (dy > 0) // up
        {
            foreach (var oy in ySet)
            {
                if (oy > y && oy <= targetY)
                    return oy - 1;
            }
        }
        else // down
        {
            foreach (var oy in ySet.Reverse())
            {
                if (oy < y && oy >= targetY)
                    return oy + 1;
            }
        }

        return targetY;
    }

    int MoveHorizontal(int y, int x, int dx, int steps)
    {
        int targetX = x + dx * steps;

        if (!horizontalObstacles.TryGetValue(y, out var xSet))
            return targetX;

        if (dx > 0) // right
        {
            foreach (var ox in xSet)
            {
                if (ox > x && ox <= targetX)
                    return ox - 1;
            }
        }
        else // left
        {
            foreach (var ox in xSet.Reverse())
            {
                if (ox < x && ox >= targetX)
                    return ox + 1;
            }
        }

        return targetX;
    }

    static void AddObstacle(Dictionary<int, SortedSet<int>> dict, int key, int val)
    {
        if (!dict.ContainsKey(key))
            dict[key] = new();
        dict[key].Add(val);
    }
}
