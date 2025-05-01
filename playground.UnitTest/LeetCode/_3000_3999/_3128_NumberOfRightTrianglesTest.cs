namespace playground.UnitTest;

public class _3128_NumberOfRightTrianglesTest
{
    [Theory]
    [InlineData("[[0,1,0],[0,1,1],[0,1,0]]", 2)]
    [InlineData("[[1,0,0,0],[0,1,0,1],[1,0,0,0]]", 0)]
    [InlineData("[[1,0,1],[1,0,0],[1,0,0]]", 2)]
    public void NumberOfRightTriangles(string A, int expected)
    {
        var actual = _3128_NumberOfRightTriangles.NumberOfRightTriangles(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
