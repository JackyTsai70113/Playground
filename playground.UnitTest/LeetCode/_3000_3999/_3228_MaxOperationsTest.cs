namespace playground.UnitTest;

public class _3228_MaxOperationsTest
{
    [Theory]
    [InlineData("1001101", 4)]
    [InlineData("00111", 0)]
    public void MaxOperations(string s, int expected)
    {
        var actual = _3228_MaxOperations.MaxOperations(s);
        Assert.Equal(expected, actual);
    }
}
