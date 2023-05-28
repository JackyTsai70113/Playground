using playground.LinkedLists;

namespace playground.UnitTest.LinkedLists;

public class ReverseListTest
{
    [Theory]
    [InlineData("[5,3,2,1]", "[1,2,3,5]")]
    public void PairSum(string head, string expected)
    {
        var actual = ReverseListClass.ReverseList(head.ToListNode());
        Assert.Equal(expected, actual.ToString());
    }
}
