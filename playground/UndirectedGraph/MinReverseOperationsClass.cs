namespace playground.UndirectedGraph;

public class MinReverseOperationsClass
{
    public static int[] MinReverseOperations(int n, int p, int[] banned, int k)
    {
        var res = Enumerable.Repeat(-1, n).ToArray();
        var trees = Enumerable.Range(0, 2).Select(x => new SortedSet<int>()).ToArray();
        var bannedSet = new HashSet<int>(banned);

        for (int i = 0; i < n; i++)
        {
            if (!bannedSet.Contains(i))
            {
                trees[i % 2].Add(i);
            }
        }

        var q = new Queue<int>();
        q.Enqueue(p);
        trees[p % 2].Remove(p);
        int count = 0;
        while (q.Count > 0)
        {
            var len = q.Count;
            for (int i = 0; i < len; ++i)
            {
                var node = q.Dequeue();
                res[node] = count;
                var nodesToRemove = trees[Math.Abs(k - 1 - node) % 2].GetViewBetween(
                    2 * Math.Max(0, node - k + 1) + k - 1 - node,
                    2 * Math.Min(node + 1, n + 1 - k) + k - 3 - node).ToArray();
                foreach (int nei in nodesToRemove)
                {
                    trees[Math.Abs(k - 1 - node) % 2].Remove(nei);
                    q.Enqueue(nei);
                }
            }
            count++;
        }
        return res;
    }
}