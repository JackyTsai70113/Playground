using playground.Arrays;

namespace playground.UnitTest.Arrays;

public class CircularGameLosersTest
{
    [Theory]
    [InlineData(5, 2, new int[] { 4, 5 })]
    [InlineData(4, 4, new int[] { 2, 3, 4 })]
    public void CircularGameLosers(int n, int k, int[] expected)
    {
        var actual = CircularGameLosersClass.CircularGameLosers(n, k);
        Assert.Equal(expected, actual);
    }
}
