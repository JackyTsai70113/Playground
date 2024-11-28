using playground._0700_0799;

namespace playground.UnitTest._0700_0799;

public class _0741_CherryPickupTest
{
    [Theory]
    [InlineData("[[0,1,-1],[1,0,-1],[1,1,1]]", 5)]
    [InlineData("[[1,1,-1],[1,-1,1],[-1,1,1]]", 0)]
    [InlineData("[[0,0,0],[-1,-1,0],[0,1,1]]", 1)]
    public void CherryPickup(string A, int expected)
    {
        var actual = _0741_CherryPickup.CherryPickup(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
