namespace playground.UnitTest;

public class _3138_MinAnagramLengthTest
{
    [Theory]
    [InlineData("abba", 2)]
    [InlineData("cdef", 4)]
    public void MinAnagramLength(string s, int expected)
    {
        var actual = _3138_MinAnagramLength.MinAnagramLength(s);
        Assert.Equal(expected, actual);
    }
}
