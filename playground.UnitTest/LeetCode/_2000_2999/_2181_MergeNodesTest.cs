using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2181_MergeNodesTest
{
    [Theory]
    [InlineData("[0,3,1,0,4,5,2,0]", "[4,11]")]
    [InlineData("[0,1,0,3,0,2,2,0]", "[1,3,4]")]
    public void MergeNodes
    (string head, string expected)
    {
        var actual = _2181_MergeNodes.MergeNodes(head.ToListNode());
        Assert.Equal(expected, actual.ToString());
    }
}
