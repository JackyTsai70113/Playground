namespace playground.UnitTest;

public class _3047_LargestSquareAreaTest
{
    [Theory]
    [InlineData("[[1,1],[2,2],[3,1]]", "[[3,3],[4,4],[6,6]]", 1)]
    [InlineData("[[1,1],[2,2],[1,2]]", "[[3,3],[4,4],[3,4]]", 1)]
    [InlineData("[[1,1],[3,3],[3,1]]", "[[2,2],[4,4],[4,2]]", 0)]
    public void LargestSquareArea(string bottomLeft, string topRight, long expected)
    {
        var actual = _3047_LargestSquareArea.LargestSquareArea(bottomLeft.To2dArr(), topRight.To2dArr());
        Assert.Equal(expected, actual);
    }
}
