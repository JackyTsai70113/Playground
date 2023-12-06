using playground.LinkedLists;

namespace playground.UnitTest.LinkedLists;

public class ReverseListTest_0206
{
    [Theory]
    [InlineData("[]", "[]")]
    [InlineData("[1,2]", "[2,1]")]
    [InlineData("[5,3,2,1]", "[1,2,3,5]")]
    [InlineData("[1,2,3,4,5]", "[5,4,3,2,1]")]
    public void ReverseList(string head, string expected)
    {
        var actual = ReverseList_206.ReverseList(head.ToListNode());
        if (!expected.ToArr().Any())
            Assert.Null(actual);
        else
            Assert.Equal(expected, actual.ToString());
    }
}
