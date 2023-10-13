namespace playground.Arrays;

public class MinProcessingTimeClass
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-processing-time
    /// </summary>
    public static int MinProcessingTime(IList<int> processorTime, IList<int> tasks)
    {
        var res = 0;
        processorTime = processorTime.OrderBy(t => t).ToList();
        tasks = tasks.OrderByDescending(t => t).ToList();
        for (int i = 0; i < processorTime.Count; i++)
        {
            res = Math.Max(res, processorTime[i] + tasks[i * 4]);
        }
        return res;
    }
}
