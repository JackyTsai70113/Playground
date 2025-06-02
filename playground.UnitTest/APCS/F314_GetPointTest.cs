using playground.APCS;

namespace playground.UnitTest.APCS;

public class F314_GetPointTest
{
    [Theory]
    [InlineData("[[2,1,4,-7,4]]", 7)]
    [InlineData("[[-4,3,-6,6,2],[-5,-8,9,-1,-3],[3,5,-4,-2,6,3]]", 20)]
    public void GetPoint(string arr, int expected)
    {
        var actual = F314_GetPoint.GetPoint(arr.To2dArr());
        Assert.Equal(expected, actual);
    }
}
