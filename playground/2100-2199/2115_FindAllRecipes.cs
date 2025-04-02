namespace playground._2100_2199;

public class _2115_FindAllRecipes
{
    public static IList<string> FindAllRecipes(string[] recipes, IList<IList<string>> ings, string[] supplies)
    {
        var set = new HashSet<string>(supplies);
        var gf = new Dictionary<string, List<string>>();
        int n = recipes.Length;
        var indegree = new Dictionary<string, int>();
        foreach (var r in recipes)
            indegree[r] = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < ings[i].Count; j++)
            {
                if (!gf.ContainsKey(ings[i][j]))
                    gf[ings[i][j]] = new();
                gf[ings[i][j]].Add(recipes[i]);
                indegree[recipes[i]]++;
            }
        }

        // topological sort
        var res = new List<string>();
        var q = new Queue<string>();
        foreach (var s in supplies)
            q.Enqueue(s);
        while (q.Count > 0)
        {
            var ing = q.Dequeue();
            if (!gf.ContainsKey(ing))
                continue;
            foreach (var recipe in gf[ing])
            {
                indegree[recipe]--;
                if (indegree[recipe] == 0)
                {
                    res.Add(recipe);
                    q.Enqueue(recipe);
                }
            }
        }
        return res;
    }
}
