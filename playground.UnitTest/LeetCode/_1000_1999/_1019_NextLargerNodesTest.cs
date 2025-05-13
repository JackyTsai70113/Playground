using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1019_NextLargerNodesTest
{
    [Theory]
    [InlineData("[2,1,5]", new int[] { 5, 5, 0 })]
    [InlineData("[2,7,4,3,5]", new int[] { 7, 0, 5, 5, 0 })]
    public void NextLargerNodes(string head, int[] expected)
    {
        var actual = _1019_NextLargerNodes.NextLargerNodes(head.ToListNode());
        Assert.Equal(expected, actual);
    }
}
