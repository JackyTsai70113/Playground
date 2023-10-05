using playground.Stacks;

namespace playground.UnitTest.Stacks;

public class DecodeAtIndexTest
{
    [Theory]
    [InlineData("leet2code3", 10, "o")]
    [InlineData("ha22", 5, "h")]
    [InlineData("a2345678999999999999999", 1, "a")]
    public void DecodeAtIndex(string s, int k, string expected)
    {
        var actual = DecodeAtIndexClass.DecodeAtIndex(s, k);
        Assert.Equal(expected, actual);
    }
}
