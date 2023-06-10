using playground.Strings;

namespace playground.UnitTest.Strings;

public class MinimizedStringLengthTest
{
    [Theory]
    [InlineData("aaabc", 3)]
    [InlineData("cbbd", 3)]
    [InlineData("dddaaa", 2)]
    public void MinimizedStringLength(string s, int expected)
    {
        var actual = MinimizedStringLengthClass.MinimizedStringLength(s);
        Assert.Equal(expected, actual);
    }
}
