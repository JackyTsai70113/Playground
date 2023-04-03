namespace playground.UnitTest;

public class SolutionTest
{
    [Theory]
    [InlineData(4, new int[] { 0, 2, 0, 1, 1, 2 }, 1)]
    [InlineData(6, new int[] { 0, 1, 0, 2, 0, 3, 1, 2, 1, 3 }, 2)]
    [InlineData(6, new int[] { 0, 1, 0, 2, 0, 3, 1, 2, }, -1)]
    [InlineData(8, new int[] { 0, 1, 0, 2, 0, 3, 1, 2, 1, 3, 2, 3, 4, 5 }, 3)]
    [InlineData(5, new int[] { 0, 1, 2, 3 }, -1)]
    [InlineData(4, new int[] { 0, 1, 0, 2 }, -1)]
    [InlineData(4, new int[] { 0, 1, 2, 3 }, -1)]
    [InlineData(5, new int[] { 0, 1, 0, 2, 2, 3 }, -1)]
    [InlineData(4, new int[] { 0, 1, 0, 2, 1, 2 }, 1)]
    [InlineData(4, new int[] { 0, 1, 0, 2, 2, 3 }, 0)]
    [InlineData(3, new int[] { 0, 1, 0, 2, 1, 2 }, 0)]
    public void MakeConnectedTest(int n, int[] connections, int expect)
    {
        var arr = ConvertTo2dArray(connections);

        int result = Solution.MakeConnected(n, arr);

        Assert.Equal(expect, result);
    }

    [Theory]
    [InlineData(3, new int[] { 0, 1, 0, 2, 1, 2 }, 0)]
    [InlineData(7, new int[] { 0, 2, 0, 5, 2, 4, 1, 6, 5, 4 }, 14)]
    public void CountPairsTest(int n, int[] edges, int expect)
    {
        var arr = ConvertTo2dArray(edges);

        long result = Solution.CountPairs(n, arr);

        Assert.Equal(expect, result);
    }

    private static int[][] ConvertTo2dArray(int[] arr)
    {
        int[][] res = new int[arr.Length / 2][];
        for (int i = 0; i < res.Length; ++i)
        {
            res[i] = new int[2] { arr[2 * i], arr[2 * i + 1] };
        }
        return res;
    }
}
