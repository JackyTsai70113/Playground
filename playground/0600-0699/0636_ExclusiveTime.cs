namespace playground._0600_0699;

public class _0636_ExclusiveTime
{
    public static int[] ExclusiveTime(int n, IList<string> logs)
    {
        var stack = new Stack<(int func, int startTime, int time)>();
        var res = new int[n];
        foreach (var log in logs)
        {
            var arr = log.Split(':');
            var func = int.Parse(arr[0]);
            var isStart = arr[1] == "start";
            var time = int.Parse(arr[2]);
            if (isStart)
            {
                stack.Push((func, time, -1));
            }
            else
            {
                int exclusiveTime = 0;
                while (stack.Peek().time != -1)
                {
                    exclusiveTime += stack.Pop().time;
                }
                var (topFunc, topStartTime, _) = stack.Pop();
                var cur = time - topStartTime - exclusiveTime + 1;
                res[topFunc] += cur;
                stack.Push((0, 0, cur + exclusiveTime));
            }
        }
        return res;
    }
}
