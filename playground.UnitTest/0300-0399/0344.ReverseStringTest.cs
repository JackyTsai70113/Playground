namespace playground.UnitTest;

public class ReverseStringTest0344
{
    [Theory]
    [InlineData(new char[] { 'h', 'e', 'l', 'l', 'o' }, new char[] { 'o', 'l', 'l', 'e', 'h' })]
    [InlineData(new char[] { 'H', 'a', 'n', 'n', 'a', 'h' }, new char[] { 'h', 'a', 'n', 'n', 'a', 'H' })]
    public void ReverseString(char[] s, char[] expected)
    {
        ReverseString0344.ReverseString(s);
        Assert.Equal(expected, s);
    }
}
