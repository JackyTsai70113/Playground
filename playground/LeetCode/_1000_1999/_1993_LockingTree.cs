namespace playground.LeetCode._1000_1999;

public class _1993_LockingTree
{
    readonly List<int>[] graph;
    readonly int[] parent;
    readonly int[] lockedParentCount;
    readonly int[] lockedChildenCount;
    readonly int[] lockUser;
    public _1993_LockingTree(int[] parent)
    {
        int n = parent.Length;
        graph = new List<int>[n];
        lockedParentCount = new int[n];
        lockedChildenCount = new int[n];
        for (int i = 0; i < n; i++) graph[i] = new();

        this.parent = parent;
        for (int i = 0; i < n; i++)
        {
            if (parent[i] != -1)
            {
                graph[parent[i]].Add(i);
            }
        }
        lockUser = new int[n];
    }

    public bool Lock(int num, int user)
    {
        if (lockUser[num] != 0)
            return false;
        lockUser[num] = user;
        var p = parent[num];
        while (p != -1)
        {
            lockedChildenCount[p]++;
            p = parent[p];
        }
        var q = new Queue<int>();
        foreach (var child in graph[num])
        {
            q.Enqueue(child);
        }
        while (q.Count > 0)
        {
            var node = q.Dequeue();
            lockedParentCount[node]++;
            foreach (var v in graph[node])
            {
                q.Enqueue(v);
            }
        }
        return true;
    }

    public bool Unlock(int num, int user)
    {
        if (lockUser[num] != user)
            return false;
        lockUser[num] = 0;
        var p = parent[num];
        while (p != -1)
        {
            lockedChildenCount[p]--;
            p = parent[p];
        }
        var q = new Queue<int>();
        foreach (var child in graph[num])
        {
            q.Enqueue(child);
        }
        while (q.Count > 0)
        {
            var node = q.Dequeue();
            lockedParentCount[node]--;
            foreach (var v in graph[node])
            {
                q.Enqueue(v);
            }
        }
        return true;
    }

    /// <summary>
    /// 1. the node can be locked by the user.
    /// 2. all the ancestors are unlocked.
    /// 3. at least one descendant are locked.
    /// </summary>
    /// <param name="num"></param>
    /// <param name="user"></param>
    /// <returns></returns>
    public bool Upgrade(int num, int user)
    {
        if (lockUser[num] != 0)
            return false;
        if (lockedParentCount[num] != 0 || lockedChildenCount[num] == 0)
            return false;
        lockUser[num] = user;
        lockedChildenCount[num] = 0;

        var p = parent[num];
        while (p != -1)
        {
            lockedChildenCount[p] += 1 - lockedChildenCount[num];
            p = parent[p];
        }

        var q = new Queue<(int, int)>();
        foreach (var child in graph[num])
        {
            q.Enqueue((child, 1));
        }
        while (q.Count > 0)
        {
            var (node, lockedCount) = q.Dequeue();
            lockedParentCount[node] += lockedCount;
            lockedChildenCount[node] = 0;
            if (lockUser[node] != 0)
            {
                lockUser[node] = 0;
                lockedCount--;
            }
            foreach (var v in graph[node])
            {
                q.Enqueue((v, lockedCount));
            }
        }
        return true;
    }
}
