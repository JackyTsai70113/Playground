namespace playground.UnitTest;

public class AreSimilarTest_2946
{
    [Theory]
    [InlineData("[[1,2,1,2],[5,5,5,5],[6,3,6,3]]", 2, true)]
    [InlineData("[[1,2,1,3],[5,5,5,5],[6,3,6,3]]", 2, false)]
    [InlineData("[[2,2],[2,2]]", 3, true)]
    [InlineData("[[1,2]]", 1, false)]
    public void AreSimilar(string A, int k, bool expected)
    {
        var actual = AreSimilar_2946.AreSimilar(A.To2dArr(), k);
        Assert.Equal(expected, actual);
    }
}
