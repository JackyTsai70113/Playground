using System.Numerics;

namespace playground.UnitTest;

public class HammingWeightTest
{
    [Theory]
    [InlineData("00000000000000000000000000001011", 3)]
    [InlineData("00000000000000000000000010000000", 1)]
    [InlineData("11111111111111111111111111111101", 31)]
    [InlineData("00000000000000000000000000001101", 3)]
    public void HammingWeight(string n, int expected)
    {
        var num = Convert.ToUInt32(n, 2);
        var actual = HammingWeight0191.HammingWeight(num);
        Assert.Equal(expected, actual);
        var actual2 = HammingWeight0191.HammingWeight2(num);
        Assert.Equal(expected, actual2);
        var actual3 = HammingWeight0191.HammingWeight3(num);
        Assert.Equal(expected, actual3);
    }
}
