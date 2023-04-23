namespace playground.Array;

public class PacificAtlanticClass
{
    public static IList<IList<int>> PacificAtlantic(int[][] heights) {
        int m = heights.Length, n = heights[0].Length;

        var p = new bool[m,n];
        void AddP(int nei, int i, int j){
            if(i<0 || i>=m || j<0 || j>=n || heights[i][j] < nei || p[i,j])
                return;
            p[i,j] = true;
            AddP(heights[i][j], i-1, j);
            AddP(heights[i][j], i+1, j);
            AddP(heights[i][j], i, j-1);
            AddP(heights[i][j], i, j+1);
        }
        for(int i = 0; i < m; ++i)
            AddP(-1, i, 0);
        for(int i = 0; i < n; ++i)
            AddP(-1, 0, i);

        var a = new bool[m,n];
        void AddA(int nei, int i, int j){
            if(i<0 || i>=m || j<0 || j>=n || heights[i][j] < nei || a[i,j])
                return;
            a[i,j] = true;
            AddA(heights[i][j], i-1, j);
            AddA(heights[i][j], i+1, j);
            AddA(heights[i][j], i, j-1);
            AddA(heights[i][j], i, j+1);
        }
        for(int i = 0; i < m; ++i)
            AddA(-1, i, n-1);
        for(int i = 0; i < n; ++i)
            AddA(-1, m-1, i);

        var res = new List<IList<int>>();
        for(int i = 0; i < m; ++i){
            for(int j = 0; j < n; ++j){
                if(p[i,j] && a[i,j])
                    res.Add(new List<int>{i, j});
            }
        }
        return res;
    }
}
