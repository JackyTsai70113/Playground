namespace playground.UnitTest;

public class MaxOperationsTest3228
{
    [Theory]
    [InlineData("1001101", 4)]
    [InlineData("00111", 0)]
    public void MaxOperations(string s, int expected)
    {
        var actual = MaxOperations3228.MaxOperations(s);
        Assert.Equal(expected, actual);
    }
}
