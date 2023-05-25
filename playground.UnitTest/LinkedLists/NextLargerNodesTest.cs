using playground.LinkedLists;

namespace playground.UnitTest.LinkedLists;

public class NextLargerNodesTest
{
    [Theory]
    [InlineData("[2,1,5]", "[5,5,0]")]
    [InlineData("[2,7,4,3,5]", "[7,0,5,5,0]")]
    public void NextLargerNodes(string a, string expected)
    {
        var actual = NextLargerNodesClass.NextLargerNodes(a.ToListNode());
        Assert.Equal(expected.ToArr(), actual);
    }
}
