namespace playground.UnitTest;

public class MergeNodesTest2181
{
    [Theory]
    [InlineData("[0,3,1,0,4,5,2,0]", "[4,11]")]
    [InlineData("[0,1,0,3,0,2,2,0]", "[1,3,4]")]
    public void MergeNodes
    (string head, string expected)
    {
        var actual = MergeNodes2181.MergeNodes(head.ToListNode());
        Assert.Equal(expected, actual.ToString());
    }
}
