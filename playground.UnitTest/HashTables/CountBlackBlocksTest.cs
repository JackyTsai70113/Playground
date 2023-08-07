using playground.HashTables;

namespace playground.UnitTest.HashTables;

public class CountBlackBlocksTest
{
    [Theory]
    [InlineData(3, 3, "[[0,0]]", new long[] { 3, 1, 0, 0, 0 })]
    [InlineData(3, 3, "[[0,0],[1,1],[0,2]]", new long[] { 0, 2, 2, 0, 0 })]
    public void CountBlackBlocks(int m, int n, string A, long[] expected)
    {
        var actual = CountBlackBlocksClass.CountBlackBlocks(m, n, A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
