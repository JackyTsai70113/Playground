using System.Text;

namespace playground;

public class MovePuzzleClass
{
    int m;
    int n;
    /// <summary>
    /// minimun steps to move Puzzle A to Puzzle B
    /// </summary>
    public List<List<char>> MovePuzzle(int[][] A, int[][] B)
    {
        m = A.Length; n = A[0].Length;
        var dirChars = new char[] { 'L', 'U', 'R', 'D' };
        var startState = ToState(A);
        var finalState = ToState(B);
        var q = new Queue<(string, List<char>)>();
        q.Enqueue((startState, new List<char>()));
        HashSet<string> seen = new() { startState };
        List<List<char>> res = new();
        while (q.Count > 0 && res.Count == 0)
        {
            for (int i = q.Count; i > 0; --i)
            {
                var (state, routes) = q.Dequeue();
                if (state == finalState)
                {
                    res.Add(routes);
                    continue;
                }
                foreach (var (nextState, nextStep) in NextSteps(state, routes))
                {
                    if (!seen.Contains(nextState))
                    {
                        seen.Add(nextState);
                        q.Enqueue((nextState, nextStep));
                    }
                }
            }
        }
        return res;
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

    public IEnumerable<(string, List<char>)> NextSteps(string state, List<char> cur)
    {
        var res = new List<(string, List<char>)>();
        var chs = state.ToCharArray();
        int index = state.IndexOf('0');
        if (index - n >= 0)
            AddState(chs, index, index - n, 'U', cur, res);
        if (index % n != 0)
            AddState(chs, index, index - 1, 'L', cur, res);
        if (index % n != n - 1)
            AddState(chs, index, index + 1, 'R', cur, res);
        if (index + n < m * n)
            AddState(chs, index, index + n, 'D', cur, res);
        return res;
    }

    public static void AddState(char[] chs, int i, int j, char dir, List<char> cur, List<(string, List<char>)> res)
    {
        var next = cur.ToList();
        next.Add(dir);
        (chs[i], chs[j]) = (chs[j], chs[i]);
        res.Add((new string(chs), next));
        (chs[i], chs[j]) = (chs[j], chs[i]);
    }
}
