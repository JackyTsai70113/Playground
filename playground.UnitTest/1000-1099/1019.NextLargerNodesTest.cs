namespace playground.UnitTest;

public class NextLargerNodesTest1019
{
    [Theory]
    [InlineData("[2,1,5]", new int[] { 5, 5, 0 })]
    [InlineData("[2,7,4,3,5]", new int[] { 7, 0, 5, 5, 0 })]
    public void NextLargerNodes(string head, int[] expected)
    {
        var actual = NextLargerNodes1019.NextLargerNodes(head.ToListNode());
        Assert.Equal(expected, actual);
    }
}
