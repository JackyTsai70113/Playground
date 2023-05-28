using playground.Arrays;

namespace playground.UnitTest.Arrays;

public class OrangesRottingTest
{
    [Theory]
    [InlineData("[[2,1,1],[1,1,0],[0,1,1]]", 4)]
    [InlineData("[[2,1,1],[0,1,1],[1,0,1]]", -1)]
    [InlineData("[[0,2]]]", 0)]
    public void OrangesRotting(string grid, int expected)
    {
        var actual = OrangesRottingClass.OrangesRotting(grid.To2dArr());
        Assert.Equal(expected, actual);
    }
}
