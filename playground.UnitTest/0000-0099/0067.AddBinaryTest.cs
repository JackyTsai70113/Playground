namespace playground.UnitTest;

public class AddBinaryTest0067
{
    [Theory]
    [InlineData("1", "11", "100")]
    [InlineData("11", "1", "100")]
    [InlineData("1010", "1011", "10101")]
    public void AddBinary(string a, string b, string expected)
    {
        var actual = AddBinary0067.AddBinary(a, b);
        Assert.Equal(expected, actual);
    }
}
