using playground._3500_3599;

namespace playground.UnitTest._3500_3599;

public class _3533_ConcatenatedDivisibilityTest
{
    [Theory]
    [InlineData("[3,12,45]", 5, "[3,12,45]")]
    [InlineData("[10,5]", 10, "[5,10]")]
    [InlineData("[1,2,3]", 5, "[]")]
    [InlineData("[25900,39695,2584,18305,75986,79563,56939,36282,89720,16517,28547,24732]", 57, "[]")]
    [InlineData("[1,9,5]", 5, "[1,9,5]")]
    [InlineData("[4,2]", 24, "[2,4]")]
    [InlineData("[6,3]", 1, "[3,6]")]
    public void ConcatenatedDivisibility(string numsStr, int k, string expectedStr)
    {
        var actual = new _3533_ConcatenatedDivisibility().ConcatenatedDivisibility(numsStr.ToArr(), k);
        Assert.Equal(expectedStr.ToArr(), actual);
    }
}
