namespace playground.UnitTest;

public class CombineTest0077
{
    [Theory]
    [InlineData(4, 2, "[[1,2],[1,3],[1,4],[2,3],[2,4],[3,4]]")]
    [InlineData(1, 1, "[[1]]")]
    public void CombineTest(int n, int k, string expected)
    {
        var actual = Combine0077.Combine(n, k);
        Assert.Equal(expected.To2dArr(), actual);
    }
}
