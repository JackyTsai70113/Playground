namespace playground.UnitTest;

public class MaximumSafenessFactorTest2812
{
    [Theory]
    [InlineData("[[1,0,0],[0,0,0],[0,0,1]]", 0)]
    [InlineData(" [[0,0,1],[0,0,0],[0,0,0]]", 2)]
    [InlineData("[[0,0,0,1],[0,0,0,0],[0,0,0,0],[1,0,0,0]]", 2)]
    public void MaximumSafenessFactor(string A, int expected)
    {
        var actual = MaximumSafenessFactor2812.MaximumSafenessFactor(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
