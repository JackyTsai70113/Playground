using playground._1400_1499;

namespace playground.UnitTest._1400_1499;

public class _1461_HasAllCodesTest
{
    [Theory]
    [InlineData("00110110", 2, true)]
    [InlineData("0110", 1, true)]
    [InlineData("0110", 2, false)]
    public void HasAllCodes(string s, int k, bool expected)
    {
        var actual = _1641_HasAllCodes_cs.HasAllCodes(s, k);
        Assert.Equal(expected, actual);
    }
}
