namespace playground.UnitTest;

public class RemoveNthFromEndTest0019
{
    [Theory]
    [InlineData("[1,2,3,4,5]", 2, "[1,2,3,5]")]
    [InlineData("[1]", 1, "[]")]
    [InlineData("[1,2]", 1, "[1]")]
    public void RemoveNthFromEnd(string head, int n, string expected)
    {
        var actual = RemoveNthFromEnd0019.RemoveNthFromEnd(head.ToListNode(), n);
        if (!expected.ToArr().Any())
            Assert.Null(actual);
        else
            Assert.Equal(expected, actual.ToString());
    }
}
