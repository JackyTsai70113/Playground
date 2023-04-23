namespace playground.Array;

public class OrangesRottingClass {
    public static int OrangesRotting(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        int fresh = 0;
        var rotten = new Queue<(int i, int j)>();
        for(int i = 0; i < m; ++i){
            for(int j = 0; j < n; ++j){
                if(grid[i][j] == 1){
                    fresh++;
                } else if (grid[i][j] == 2){
                    rotten.Enqueue((i, j));
                }
            }
        }

        int time = 0;
        while(rotten.Count > 0 && fresh > 0){
            time++;
            for(int k = rotten.Count; k > 0; --k){
                var (i, j) = rotten.Dequeue();
                fresh = Rotten(grid, i-1, j, rotten, fresh);
                fresh = Rotten(grid, i+1, j, rotten, fresh);
                fresh = Rotten(grid, i, j-1, rotten, fresh);
                fresh = Rotten(grid, i, j+1, rotten, fresh);
            }
        }
        return fresh == 0 ? time : -1;
    }
    private static int Rotten(int[][] grid, int i, int j, Queue<(int, int)> rotten, int fresh) {
        if(i<0 || j<0 || i >= grid.Length || j >= grid[0].Length || grid[i][j] != 1)
            return fresh;
        rotten.Enqueue((i,j));
        grid[i][j] = 2;
        return fresh-1;
    }
}