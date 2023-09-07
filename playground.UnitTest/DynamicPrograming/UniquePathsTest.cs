using playground.DynamicPrograming;

namespace playground.UnitTest.DynamicPrograming;

public class UniquePathsTest
{
    [Theory]
    [InlineData(3, 7, 28)]
    [InlineData(3, 2, 3)]
    public void UniquePaths(int m, int n, int expected)
    {
        var actual = UniquePathsClass.UniquePaths(m, n);
        Assert.Equal(expected, actual);
    }
}
