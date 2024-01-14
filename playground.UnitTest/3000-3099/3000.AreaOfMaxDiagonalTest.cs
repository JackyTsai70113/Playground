namespace playground.UnitTest;

public class AreaOfMaxDiagonalTest3000
{
    [Theory]
    [InlineData("[[9,3],[8,6]]", 48)]
    [InlineData("[[3,4],[4,3]]", 12)]
    [InlineData("[[25,60],[33,56]]", 1848)]
    public void AreaOfMaxDiagonal(string dimensions, int expected)
    {
        var actual = AreaOfMaxDiagonal3000.AreaOfMaxDiagonal(dimensions.To2dArr());
        Assert.Equal(expected, actual);
    }
}
