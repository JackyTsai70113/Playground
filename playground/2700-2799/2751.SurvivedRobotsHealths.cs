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
        List<int> lefts = new();
        Stack<int> rights = new();
        foreach (var idx in indexes)
        {
            if (directions[idx] == 'R')
                rights.Push(idx);
            else
            {
                while (rights.Count > 0)
                {
                    if (healths[rights.Peek()] == healths[idx])
                    {
                        healths[rights.Pop()] = 0;
                        healths[idx] = 0;
                        break;
                    }
                    else if (healths[rights.Peek()] > healths[idx])
                    {
                        healths[rights.Peek()]--;
                        healths[idx] = 0;
                        break;
                    }
                    else
                    {
                        healths[rights.Pop()] = 0;
                        healths[idx]--;
                    }
                }
                if (healths[idx] > 0)
                    lefts.Add(idx);
            }
        }
        var res = new int[lefts.Count + rights.Count];
        for (int i = 0, j = 0; i < n; i++)
        {
            if (healths[i] > 0)
                res[j++] = healths[i];
        }
        return res;
    }
}
