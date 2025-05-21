using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1110_DelNodesTest
{
    [Theory]
    [InlineData("[1,2,3,4,5,6,7]", new int[] { 3, 5 }, "[[1,2,null,4],[6],[7]]")]
    [InlineData("[1,2,4,null,3]", new int[] { 3 }, "[[1,2,4]]")]
    [InlineData("[1,2,4,3]", new int[] { 3 }, "[[1,2,4]]")]
    public void DelNodesIteration(string root, int[] to_delete, string expected)
    {
        var actual = _1110_DelNodes.DelNodesIteration(root.ToTreeNode(), to_delete);
        var expectedTrees = expected.ToArr<object>();
        Assert.Equal(expectedTrees.Length, actual.Count);
        for (int i = 0; i < expectedTrees.Length; i++)
        {
            Assert.Equal(expectedTrees[i].ToString(), actual[i].ToString());
        }
    }

    [Theory]
    [InlineData("[1,2,3,4,5,6,7]", new int[] { 3, 5 }, "[[1,2,null,4],[6],[7]]")]
    [InlineData("[1,2,4,null,3]", new int[] { 3 }, "[[1,2,4]]")]
    [InlineData("[1,2,4,3]", new int[] { 3 }, "[[1,2,4]]")]
    public void DelNodesRecursion(string root, int[] to_delete, string expected)
    {
        var actual = _1110_DelNodes.DelNodesRecursion(root.ToTreeNode(), to_delete);
        var expectedTrees = expected.ToArr<object>();
        Assert.Equal(expectedTrees.Length, actual.Count);
        for (int i = 0; i < expectedTrees.Length; i++)
        {
            Assert.Equal(expectedTrees[i].ToString(), actual[i].ToString());
        }
    }
}
