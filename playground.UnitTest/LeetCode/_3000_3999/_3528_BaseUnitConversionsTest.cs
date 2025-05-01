using playground._3500_3599;

namespace playground.UnitTest._3500_3599;

public class _3528_BaseUnitConversionsTest
{
    [Theory]
    [InlineData("[[0,1,2],[1,2,3]]", new int[] { 1, 2, 6 })]
    [InlineData("[[0,1,2],[0,2,3],[1,3,4],[1,4,5],[2,5,2],[4,6,3],[5,7,4]]", new int[] { 1, 2, 3, 8, 10, 6, 30, 24 })]
    public void BaseUnitConversions(string conversions, int[] expected)
    {
        var actual = _3528_BaseUnitConversions.BaseUnitConversions(conversions.To2dArr());
        Assert.Equal(expected, actual);
    }
}
