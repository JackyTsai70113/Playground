using playground.Mathematics;

namespace playground.UnitTest.Mathematics;

public class FindPrimePairsTest
{
    [Theory]
    [InlineData(10, "[[3,7],[5,5]]")]
    [InlineData(2, "[]")]
    public void FindPrimePairs(int n, string expected)
    {
        var actual = FindPrimePairsClass.FindPrimePairs(n);
        Assert.Equal(expected.To2dArr(), actual);
    }
}
