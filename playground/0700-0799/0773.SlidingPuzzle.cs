using System.Text;

namespace playground;

public class SlidingPuzzle0773
{
    int m;
    int n;
    readonly string targetState = "123450";
    public int SlidingPuzzle(int[][] A)
    {
        m = A.Length; n = A[0].Length;
        var q = new Queue<string>();
        var seen = new HashSet<string>();
        var firstState = ToState(A);
        q.Enqueue(firstState);
        seen.Add(firstState);
        int step = 0;
        while (q.Count > 0)
        {
            for (int i = q.Count; i > 0; i--)
            {
                var state = q.Dequeue();
                if (state == targetState)
                    return step;
                foreach (var nextState in NextStates(state))
                {
                    if (!seen.Contains(nextState))
                    {
                        seen.Add(nextState);
                        q.Enqueue(nextState);
                    }
                }
            }
            step++;
        }
        return -1;
    }

    public string ToState(int[][] A)
    {
        StringBuilder sb = new();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                sb.Append(A[i][j]);
            }
        }
        return sb.ToString();
    }

    public IEnumerable<string> NextStates(string state)
    {
        var res = new List<string>();
        var chs = state.ToCharArray();
        int index = state.IndexOf('0');
        if (index - n >= 0)
            AddState(chs, index, index - n, res);
        if (index % n != 0)
            AddState(chs, index, index - 1, res);
        if (index % n != n - 1)
            AddState(chs, index, index + 1, res);
        if (index + n < m * n)
            AddState(chs, index, index + n, res);
        return res;
    }

    public static void AddState(char[] chs, int i, int j, List<string> res)
    {
        (chs[i], chs[j]) = (chs[j], chs[i]);
        res.Add(new string(chs));
        (chs[i], chs[j]) = (chs[j], chs[i]);
    }
}
