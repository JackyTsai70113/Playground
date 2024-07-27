namespace playground.UnitTest;

public class BuildMatrixTest2392
{
    [Theory]
    [InlineData(3, "[[1,2],[3,2]]", "[[2,1],[3,2]]", "[[0,0,1],[3,0,0],[0,2,0]]")]
    [InlineData(3, "[[1,2],[2,3],[3,1],[2,3]]", "[[2,1]]", "[]")]
    public void BuildMatrix(int k, string rowConditions, string colConditions, string expected)
    {
        var actual = BuildMatrix2392.BuildMatrix(k, rowConditions.To2dArr(), colConditions.To2dArr());
        Assert.Equal(expected.To2dArr(), actual);
    }
}
