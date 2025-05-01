using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0191_HammingWeightTest
{
    [Theory]
    [InlineData("00000000000000000000000000001011", 3)]
    [InlineData("00000000000000000000000010000000", 1)]
    [InlineData("11111111111111111111111111111101", 31)]
    [InlineData("00000000000000000000000000001101", 3)]
    public void HammingWeight(string n, int expected)
    {
        var num = Convert.ToUInt32(n, 2);
        var actual = _0191_HammingWeight.HammingWeight(num);
        Assert.Equal(expected, actual);
        var actual2 = _0191_HammingWeight.HammingWeight2(num);
        Assert.Equal(expected, actual2);
        var actual3 = _0191_HammingWeight.HammingWeight3(num);
        Assert.Equal(expected, actual3);
    }
}
