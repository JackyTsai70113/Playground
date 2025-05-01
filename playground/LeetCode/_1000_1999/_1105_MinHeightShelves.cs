namespace playground;

public class _1105_MinHeightShelves
{
    public static int MinHeightShelves(int[][] books, int shelfWidth)
    {
        int[,] dp = new int[books.Length, shelfWidth + 1];
        return Dfs(books, shelfWidth, 0, 0, 0, dp);
    }
    static int Dfs(int[][] books, int shelfWidth, int start, int curW, int curH, int[,] dp)
    {
        if (start == books.Length) return curH;
        if (dp[start, curW] != 0) return dp[start, curW];
        int wo = dp[start, curW] = curH + Dfs(books, shelfWidth, start + 1, books[start][0], books[start][1], dp);
        if (books[start][0] + curW > shelfWidth)
        {
            dp[start, curW] = wo;
        }
        else
        {
            int w = Dfs(books, shelfWidth, start + 1, books[start][0] + curW, Math.Max(books[start][1], curH), dp);
            dp[start, curW] = Math.Min(w, wo);
        }
        return dp[start, curW];
    }
}
