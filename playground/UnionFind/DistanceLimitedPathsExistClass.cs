namespace playground.UnionFind;

public class DistanceLimitedPathsExistClass
{
    public static bool[] DistanceLimitedPathsExist(int n, int[][] edgeList, int[][] queries)
    {
        queries = queries.Select((x, i) => new int[] { x[0], x[1], x[2], i }).OrderBy(x => x[2]).ToArray();
        edgeList = edgeList.OrderBy(e => e[2]).ToArray();
        var uf = new UnionFindClass(n);
        var res = new bool[queries.Length];
        int edgesIndex = 0;
        foreach(var query in queries){
            var p = query[0];
            var q = query[1];
            var limit = query[2];
            var queriesIndex = query[3];
            while (edgesIndex < edgeList.Length && edgeList[edgesIndex][2] < limit){
                var node1 = edgeList[edgesIndex][0];
                var node2 = edgeList[edgesIndex][1];
                uf.Join(node1, node2);
                edgesIndex++;
            }
            res[queriesIndex] = uf.AreConnected(p, q);
        }
        return res;
    }
}
