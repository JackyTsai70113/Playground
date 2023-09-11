namespace playground.Arrays;

public class MovePuzzleClass
{
    public static List<List<char>> MovePuzzle(int[][] A, int[][] B)
    {
        int[,] start = new int[3, 3], target = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                start[i, j] = A[i][j];
                target[i, j] = B[i][j];
            }
        }

        string ToState(int[,] puzzle)
        {
            return string.Join("", puzzle.Cast<int>());
        }

        int[,] ToPuzzle(string state)
        {
            var res = new int[3, 3];
            for (int i = 0, cur = 0; i < 3; ++i)
                for (int j = 0; j < 3; j++)
                    res[i, j] = state[cur++] - '0';
            return res;
        }

        int[] dirs = new int[] { 0, -1, 0, 1, 0 };
        var dirChars = new char[] { 'L', 'U', 'R', 'D' };
        var startState = ToState(start);
        var targetState = ToState(target);
        var q = new Queue<(string, List<char>)>();
        q.Enqueue((startState, new List<char>()));
        var seen = new HashSet<string>
        {
            startState
        };
        var res = new List<List<char>>();
        while (q.Count > 0)
        {
            var meet = false;
            for (int qCount = q.Count; qCount > 0; --qCount)
            {
                var (state, routes) = q.Dequeue();
                if (state == targetState)
                {
                    meet = true;
                    res.Add(routes);
                }
                var puzzle = ToPuzzle(state);
                for (int i = 0; i < 3; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        if (puzzle[i, j] != 0)
                            continue;
                        for (int k = 0; k < 4; ++k)
                        {
                            int x = i + dirs[k], y = j + dirs[k + 1];
                            if (x < 0 || y < 0 || x == 3 || y == 3)
                                continue;
                            var newPuzzle = puzzle.Clone() as int[,];
                            (newPuzzle[x, y], newPuzzle[i, j]) = (newPuzzle[i, j], newPuzzle[x, y]);
                            var newState = ToState(newPuzzle);
                            if (seen.Contains(newState))
                                continue;
                            seen.Add(newState);
                            var newRoutes = new List<char>(routes)
                        {
                            dirChars[k]
                        };
                            q.Enqueue((newState, newRoutes));
                        }
                    }
                }
            }
            if (meet)
                break;
        }
        return res;
    }
}
