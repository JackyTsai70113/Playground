namespace playground;

public class CatMouseGame0913
{
    /// <summary>
    /// https://leetcode.com/problems/cat-and-mouse
    /// </summary>
    public static int CatMouseGame(int[][] graph)
    {
        int n = graph.Length;
        // int[cat, mouse, catMove = 0]
        int[,,] color = new int[n, n, 2], outDegree = new int[n, n, 2];
        for (int cat = 0; cat < n; cat++)
        {
            for (int mouse = 0; mouse < n; mouse++)
            {
                outDegree[cat, mouse, 0] = graph[mouse].Length;
                outDegree[cat, mouse, 1] = graph[cat].Length;
                foreach (var v in graph[cat])
                {
                    if (v == 0)
                    {
                        outDegree[cat, mouse, 1]--;
                        break;
                    }
                }
            }
        }
        var q = new Queue<(int cat, int mouse, int catMove, int result)>();
        for (int i = 1; i < n; i++)
        {
            for (int catMove = 0; catMove < 2; catMove++)
            {
                color[i, 0, catMove] = 1; // mouse reaches hole
                q.Enqueue((i, 0, catMove, 1));
                color[i, i, catMove] = 2; // same position
                q.Enqueue((i, i, catMove, 2));
            }
        }
        while (q.Count > 0)
        {
            var (cat, mouse, catMove, result) = q.Dequeue();
            if (cat == 2 && mouse == 1 && catMove == 0)
                return result;
            int prevCatMove = 1 - catMove;
            foreach (var prev in graph[prevCatMove == 1 ? cat : mouse])
            {
                int prevCat = prevCatMove == 1 ? prev : cat;
                int prevMouse = prevCatMove == 1 ? mouse : prev;
                if (prevCat == 0) // cat can't reach hole
                    continue;
                if (color[prevCat, prevMouse, prevCatMove] > 0) // known result
                    continue;
                if (prevCatMove == 1 && result == 2 || // mouse success
                    prevCatMove == 0 && result == 1 || // cat success
                    --outDegree[prevCat, prevMouse, prevCatMove] == 0) // use current result
                {
                    color[prevCat, prevMouse, prevCatMove] = result;
                    q.Enqueue((prevCat, prevMouse, prevCatMove, result));
                }
            }
        }
        return color[2, 1, 0];
    }
}
