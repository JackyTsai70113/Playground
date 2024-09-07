namespace playground;

public class RobotSim0874
{
    public static int RobotSim(int[] commands, int[][] obstacles)
    {
        Dictionary<int, List<int>> rows = new(), cols = new();
        foreach (var ob in obstacles)
        {
            AddToDict(rows, ob[0], ob[1]);
            AddToDict(cols, ob[1], ob[0]);
        }
        int x = 0, y = 0, xx, yy;
        int dirIndex = 0, max = 0, index;
        foreach (var com in commands)
        {
            if (com == -1)
                dirIndex = (dirIndex + 1) % 4;
            else if (com == -2)
                dirIndex = (dirIndex + 3) % 4;
            else
            {
                if (dirIndex == 0)
                {
                    yy = y + com;
                    if (rows.ContainsKey(x))
                    {
                        index = leftIndex(rows[x], y);
                        if (index < rows[x].Count && rows[x][index] <= y+com)
                        {
                            yy = rows[x][index] - 1;
                        }
                    }
                    y = yy;
                }
                else if (dirIndex == 1)
                {
                    xx = x + com;
                    if (cols.ContainsKey(y))
                    {
                        index = leftIndex(cols[y], x);
                        if (index < cols[y].Count && cols[y][index] <= x + com)
                        {
                            xx = cols[y][index] - 1;
                        }
                    }
                    x = xx;
                }
                else if (dirIndex == 2)
                {
                    yy = y - com;
                    if (rows.ContainsKey(x))
                    {
                        index = rightIndex(rows[x], y);
                        if (index >= 0 && rows[x][index] >= y - com)
                        {
                            yy = rows[x][index] + 1;
                        }
                    }
                    y = yy;
                }
                else
                {
                    xx = x - com;
                    if (cols.ContainsKey(y))
                    {
                        index = rightIndex(cols[y], x);
                        if (index >= 0 && cols[y][index] >= x - com)
                        {
                            xx = cols[y][index] + 1;
                        }
                    }
                    x = xx;
                }
                max = Math.Max(max, x * x + y * y);
            }
        }
        return max;
    }

    public static void AddToDict(Dictionary<int, List<int>> dict, int x, int y)
    {
        if (!dict.ContainsKey(x))
            dict[x] = new();
        int index = leftIndex(dict[x], y);
        if (index < dict[x].Count)
            dict[x].Insert(index, y);
        else
            dict[x].Add(y);
    }
    public static int leftIndex(List<int> nums, int target)
    {
        int l = 0, r = nums.Count;
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (nums[m] > target)
                r = m;
            else
                l = m + 1;
        }
        return l;
    }
    public static int rightIndex(List<int> nums, int target)
    {
        int l = -1, r = nums.Count - 1;
        while (l < r)
        {
            int m = l + (r - l + 1) / 2;
            if (nums[m] < target)
                l = m;
            else
                r = m - 1;
        }
        return l;
    }
}
