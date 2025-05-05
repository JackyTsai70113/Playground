using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1710_MaximumUnitsTest
{
    [Theory]
    [InlineData("[[1,3],[2,2],[3,1]]", 4, 8)]
    [InlineData("[[5,10],[2,5],[4,7],[3,9]]", 10, 91)]
    public void MaximumUnits(string boxTypes, int truckSize, int expected)
    {
        var actual = _1710_MaximumUnits.MaximumUnits(boxTypes.To2dArr(), truckSize);
        Assert.Equal(expected, actual);
    }
}
