namespace playground.UnitTest;

public class NumberOfBoomerangsTest0447
{
    [Theory]
    [InlineData("[[0,0],[1,0],[2,0]]", 2)]
    [InlineData("[[1,1],[2,2],[3,3]]", 2)]
    [InlineData("[[1,1]]", 0)]
    public void NumberOfBoomerangs(string points, int expected)
    {
        var actual = NumberOfBoomerangs0447.NumberOfBoomerangs(points.To2dArr());
        Assert.Equal(expected, actual);
    }
}
