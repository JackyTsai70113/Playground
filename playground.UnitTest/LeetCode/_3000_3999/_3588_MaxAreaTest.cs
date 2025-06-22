using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3588_MaxAreaTest
{
    [Theory]
    [InlineData("[[1,1],[1,2],[3,2],[3,3]]", 2)]
    [InlineData("[[1,1],[2,2]]", -1)]
    [InlineData("[[1,1],[2,2],[3,3]]", -1)]
    [InlineData("[[1,1],[2,2],[3,3],[4,4]]", -1)]
    [InlineData("[[1,1],[2,2],[3,3],[4,4],[5,5]]", -1)]
    public void MaxArea(string input, long expected)
    {
        var actual = _3588_MaxArea.MaxArea(input.To2dArr());
        Assert.Equal(expected, actual);
    }
}
