namespace playground.UnitTest;

public class MinAnagramLengthTest3138
{
    [Theory]
    [InlineData("abba", 2)]
    [InlineData("cdef", 4)]
    public void MinAnagramLength(string s, int expected)
    {
        var actual = MinAnagramLength3138.MinAnagramLength(s);
        Assert.Equal(expected, actual);
    }
}
