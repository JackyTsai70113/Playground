using playground.Arrays;

namespace playground.UnitTest.Arrays;

public class CircularGameLosersTest
{
    [Theory]
    [InlineData(5, 2, "[4,5]")]
    [InlineData(4, 4, "[2,3,4]")]
    public void CircularGameLosers(int n, int k, string expected)
    {
        int[] actual = CircularGameLosersClass.CircularGameLosers(n, k);
        Assert.Equal(actual, expected.ToArr<int>());
    }
}
