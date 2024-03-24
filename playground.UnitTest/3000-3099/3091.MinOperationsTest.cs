namespace playground.UnitTest;

public class MinOperationsTest3091
{
    [Theory]
    [InlineData(11, 5)]
    [InlineData(10, 5)]
    [InlineData(9, 4)]
    [InlineData(3, 2)]
    [InlineData(1, 0)]
    public void MinOperations(int k, int expected)
    {
        var actual = MinOperations3091.MinOperations(k);
        Assert.Equal(expected, actual);
    }
}
