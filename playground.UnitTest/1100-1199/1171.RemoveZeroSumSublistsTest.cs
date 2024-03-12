namespace playground.UnitTest;

public class RemoveZeroSumSublistsTest1171
{
    [Theory]
    [InlineData("[1,2,-3,3,1]", "[3,1]")]
    [InlineData("[1,2,3,-3,4]", "[1,2,4]")]
    [InlineData("[1,2,3,-3,-2]", "[1]")]
    [InlineData("[1,3,2,-3,-2,5,5,-5,1]", "[1,5,1]")]
    [InlineData("[0,0]", "[]")]
    [InlineData("[1]", "[1]")]
    public void RemoveZeroSumSublists(string head, string expected)
    {
        var actual = RemoveZeroSumSublists1171.RemoveZeroSumSublists(head.ToListNode());
        if (!expected.ToArr().Any())
            Assert.Null(actual);
        else
            Assert.Equal(expected, actual.ToString());
    }
}
