namespace playground;

public class MinimumOperationsToMakeEqual3
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-number-of-operations-to-make-x-and-y-equal
    /// </summary>
    public static int MinimumOperationsToMakeEqual(int x, int y)
    {
        var set = new HashSet<int>();
        var q = new Queue<int>();
        q.Enqueue(x);
        int time = -1;
        bool isBreak = false;
        while (!isBreak)
        {
            time++;
            for (int i = q.Count; i > 0; i--)
            {
                var x0 = q.Dequeue();
                set.Add(x0);
                if (x0 == y)
                {
                    isBreak = true;
                    break;
                }
                if (x0 - 1 >= 1 && !set.Contains(x0 - 1))
                    q.Enqueue(x0 - 1);
                if (!set.Contains(x0 + 1))
                    q.Enqueue(x0 + 1);
                if (x0 % 5 == 0 && !set.Contains(x0 % 5))
                    q.Enqueue(x0 / 5);
                if (x0 % 11 == 0 && !set.Contains(x0 % 11))
                    q.Enqueue(x0 / 11);
            }
        }
        return time;
    }
}
