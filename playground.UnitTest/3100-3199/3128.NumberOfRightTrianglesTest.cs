namespace playground.UnitTest;

public class NumberOfRightTrianglesTest3128
{
    [Theory]
    [InlineData("[[0,1,0],[0,1,1],[0,1,0]]", 2)]
    [InlineData("[[1,0,0,0],[0,1,0,1],[1,0,0,0]]", 0)]
    [InlineData("[[1,0,1],[1,0,0],[1,0,0]]", 2)]
    public void NumberOfRightTriangles(string A, int expected)
    {
        var actual = NumberOfRightTriangles3128.NumberOfRightTriangles(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
