using playground.DepthFirstSearch;

namespace playground.UnitTest.DepthFirstSearch;

public class MaximumDetonationTest
{
    [Theory]
    [InlineData("[[1,1,5],[10,10,5]]", 1)]
    [InlineData("[[1,2,3],[2,3,1],[3,4,2],[4,5,3],[5,6,4]]", 5)]
    public void MaximumDetonation(string bs, int expected)
    {
        var actual = MaximumDetonationClass.MaximumDetonation(bs.To2dArr());
        Assert.Equal(expected, actual);
    }
}
