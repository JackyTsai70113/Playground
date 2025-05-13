namespace playground.UnitTest.LeetCode._3000_3999;

public class _3091_MinOperationsTest
{
    [Theory]
    [InlineData(11, 5)]
    [InlineData(10, 5)]
    [InlineData(9, 4)]
    [InlineData(3, 2)]
    [InlineData(1, 0)]
    public void MinOperations(int k, int expected)
    {
        var actual = _3091_MinOperations.MinOperations(k);
        Assert.Equal(expected, actual);
    }
}
