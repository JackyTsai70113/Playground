namespace playground;

public class _1298_MaxCandies
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-candies-you-can-get-from-boxes
    /// </summary>
    public static int MaxCandies(int[] status, int[] candies, int[][] keys, int[][] containedBoxes, int[] initialBoxes)
    {
        var res = 0;
        bool canOpen = true;
        var q = new Queue<int>();
        foreach (var box in initialBoxes) q.Enqueue(box);
        var curBoxes = new HashSet<int>();
        while (canOpen && q.Count > 0)
        {
            canOpen = false;
            for (int i = q.Count; i > 0; i--)
            {
                var box = q.Dequeue();
                if (status[box] == 0)
                {
                    curBoxes.Add(box);
                    q.Enqueue(box);
                    continue;
                }
                res += candies[box];
                foreach (var key in keys[box])
                {
                    if (curBoxes.Contains(key))
                        canOpen = true;
                    status[key] = 1;
                }
                foreach (var nextBox in containedBoxes[box])
                {
                    if (status[nextBox] == 1)
                        canOpen = true;
                    q.Enqueue(nextBox);
                }
            }
        }
        return res;
    }
}
