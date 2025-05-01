using playground.APCS;

namespace playground.UnitTest;

public class F607_CutWoodTest
{
    [Theory]
    [InlineData(7, "[[2,2],[3,1],[5,3]]", 14)]
    [InlineData(8, "[[2,3],[6,1],[5,2]]", 19)]
    public void CutWood(int length, string cuts, int expected)
    {
        var actual = F607_CutWood.CutWood(length, cuts.To2dArr());
        Assert.Equal(expected, actual);
    }
}
