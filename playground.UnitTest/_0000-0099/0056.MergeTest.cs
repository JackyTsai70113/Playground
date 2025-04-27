namespace playground.UnitTest;

public class MergeTest0056
{
    [Theory]
    [InlineData("[[1,3],[2,6],[8,10],[15,18]]", "[[1,6],[8,10],[15,18]]")]
    [InlineData("[[1,4],[4,5]]", "[[1,5]]")]
    public void Merge(string A, string expected)
    {
        var actual = Merge0056.Merge(A.To2dArr());
        Assert.Equal(expected.To2dArr(), actual);
    }
}
